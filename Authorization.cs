using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Authorization : Form
    {
        SqlConnection connection;
        public Authorization()
        {
            InitializeComponent();
            loadButtonClecked();
            this.KeyPreview = true;
            connection = new SqlConnection();
            
        }
        
        private void loadButtonClecked()
        {
            visiblePassCheck.Click += (s, e) => {
                if (visiblePassCheck.Checked)
                {
                    passwordBox.PasswordChar = (char)0;
                }
                else
                {
                    passwordBox.PasswordChar = '•';
                }
            };
            logInButton.Click += (s, e) =>
            {
                Console.WriteLine(connection.State);
                if (connection.State == ConnectionState.Closed)
                {
                    var task = Classes.DBUtils.setupConnection();
                    LoaderForm ld = new LoaderForm(task.AsTask());
                    ld.ShowDialog();
                    connection = task.Result;
                }
                DataTable dt = Classes.DBUtils.loadDataTableAuthorization(
                    $@"select * from users where name_user = '{userNameBox.Text}' and password = '{passwordBox.Text}'", 
                    connection);
                if (dt.Rows.Count > 0) 
                {
                    switch (dt.Rows[0].ItemArray[7].ToString())
                    {
                        case "1":
                            Console.WriteLine("Admin");
                            MainForm mf = new MainForm(this, connection);
                            mf.Show();
                            break;
                        case "2":
                            Console.WriteLine("Manager");
                            break;
                        case "3":
                            Console.WriteLine("Client");
                            break;
                        default:
                            Console.WriteLine("Error in column 7 from table users!");
                            MessageBox.Show("Ошибка определения роли пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Пароль или логин не верны!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                setupStringConnection setupString = new setupStringConnection();
                setupString.ShowDialog();
            }
        }
    }
}
