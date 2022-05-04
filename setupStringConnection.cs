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
    public partial class setupStringConnection : Form
    {
        SqlConnectionStringBuilder stringBuilder;
        public setupStringConnection()
        {
            InitializeComponent();
            loadEventButton();
            stringBuilder = new SqlConnectionStringBuilder();
        }

        private void loadEventButton()
        {
            cancelButton.Click += (s, e) =>
            {
                this.Close();
            };

        }

        private void serverNameBox_TextChanged(object sender, EventArgs e)
        {
            groupUserDataSql.Enabled = true;
        }

        private void politicSqlBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (politicSqlBox.SelectedIndex == 0)
            {
                userNameSqlBox.Enabled = false;
                passwordSqlBox.Enabled = false;
            }
            if (politicSqlBox.SelectedIndex == 1)
            {
                userNameSqlBox.Enabled = true;
                passwordSqlBox.Enabled = true;
            }
            dataBasesList.Enabled = true;
        }

        private void vivsblePasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (vivsblePasswordCheck.Checked)
            {
                passwordSqlBox.PasswordChar = '•';
            }
            else
            {
                passwordSqlBox.PasswordChar = (char)0;
            }
        }

        private void dataBasesList_DropDown(object sender, EventArgs e)
        {
            dataBasesList.Items.Clear();
            stringBuilder.DataSource = serverNameBox.Text;
            if (politicSqlBox.SelectedIndex == 0)
            {
                stringBuilder.IntegratedSecurity = true;
            }
            if (politicSqlBox.SelectedIndex == 1)
            {
                stringBuilder.UserID = userNameSqlBox.Text;
                stringBuilder.Password = passwordSqlBox.Text;
            }
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringBuilder.ConnectionString))
                {
                    sqlConn.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = sqlConn;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "sp_helpdb";

                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dataBasesList.Items.Add(row["name"].ToString());
                    }
                }
                checkConnectButton.Enabled = true;
                WriteConnectButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataBasesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringBuilder.InitialCatalog = dataBasesList.Text;
        }

        private void checkConnectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringBuilder.ConnectionString, "Строка соединения");
        }

        private void WriteConnectButton_Click(object sender, EventArgs e)
        {
            Classes.DBUtils.AddUpdateAppSettings("DefaultConnection", stringBuilder.ConnectionString);
        }
    }
}
