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
    public partial class MainForm : Form
    {
        SqlConnection connection = new SqlConnection();
        List<UserControl> userControls = new List<UserControl>();
        Authorization authorization;
        public MainForm(Authorization authorization, SqlConnection connection)
        {
            InitializeComponent();

            Console.WriteLine("MainForm: " + connection.State);
            this.connection = connection;
            Console.WriteLine("MainForm: " + connection.State);

            addedUserControl();
            this.authorization = authorization;
            authorization.Hide();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            setupUserControl(userControls[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void addedUserControl()
        {
            userControls.Add(new UserControls.Catalogs(connection));
            //userControls.Add(new UserControls.addedPicture(connection));
            userControls.Add(new UserControls.AddedBook(connection));
        }

        private void setupUserControl(UserControl userControl)
        {
            if (mainContent.Controls.Count > 0)
                mainContent.Controls.Clear();
            mainContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = MessageBox.Show("Вернуть к авторизации?", "Завершение работы", MessageBoxButtons.YesNoCancel);
            if (message.Equals(DialogResult.Yes))
            {
                authorization.Show();
            } else if (message.Equals(DialogResult.Cancel))
            {
                e.Cancel = true;
            } else
            {
                authorization.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MyAccountButton_Click(object sender, EventArgs e)
        {
            setupUserControl(userControls[1]);
        }
    }
}
