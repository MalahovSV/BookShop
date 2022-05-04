using BookShop.UserControls;
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
    public partial class AuthorTable : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        AddedBook ParentUserControl;
        DataTable AuthorDataTable = new DataTable();
        SqlConnection sqlConnection;
        public AuthorTable(SqlConnection sqlConnection, AddedBook addedBook)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            ParentUserControl = addedBook;
            loadDataInTable();
            CreateCommandDataAdapter();
        }
        private void loadDataInTable()
        {
            dataGridAuthor.Refresh();
            AuthorDataTable = Classes.DBUtils.loadDataTableAuthorization("sp_Get_Author", sqlConnection);
           
            dataGridAuthor.DataSource = AuthorDataTable;
            dataGridAuthor.Columns[0].ReadOnly = true;
        }
        private void CreateCommandDataAdapter()
        {
            #region InsertComand
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Author (surname, first_name, second_name, email) values(@surname, @first_name, @second_name, @email)", sqlConnection);
            dataAdapter.InsertCommand.Parameters.Add("@surname", SqlDbType.VarChar, 0, "Фамилия");
            dataAdapter.InsertCommand.Parameters.Add("@first_name", SqlDbType.VarChar, 30, "Имя");
            dataAdapter.InsertCommand.Parameters.Add("@second_name", SqlDbType.VarChar, 30, "Отчество");
            dataAdapter.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 30, "Почта");
            #endregion

            #region UpdateCommand
            dataAdapter.UpdateCommand = new SqlCommand(@"update  author set 
                                                        surname = @surname, 
                                                        first_name = @first_name, 
                                                        second_name = @second_name, 
                                                        email = @email
                                                        where pk_author = @pk_author", sqlConnection);
            dataAdapter.UpdateCommand.Parameters.Add("@pk_author", SqlDbType.Int, 0, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@surname", SqlDbType.VarChar, 30, "Фамилия");
            dataAdapter.UpdateCommand.Parameters.Add("@first_name", SqlDbType.VarChar, 30, "Имя");
            dataAdapter.UpdateCommand.Parameters.Add("@second_name", SqlDbType.VarChar, 30, "Отчество");
            dataAdapter.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 30, "Почта");
            #endregion

            #region DeleteCommand
            dataAdapter.DeleteCommand = new SqlCommand("delete from author where pk_author = @pk_author", sqlConnection);
            dataAdapter.DeleteCommand.Parameters.Add("@pk_author", SqlDbType.Int, 0, "ID");
            #endregion
        }

        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                dataAdapter.Update(AuthorDataTable);
                Classes.DBUtils.ExecuteNonQuerySqlCommand("SET IDENTITY_INSERT author ON;", sqlConnection);
                Console.WriteLine("[INFO] {0, 50}", "AuthorDataSet update succefully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0, 50}", ex.Message);
                Console.WriteLine("[Command] {0, 50}", dataAdapter.InsertCommand.CommandText);
            }
            finally
            {
                loadDataInTable();
            }
        }

        private void AuthorTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentUserControl.loadAuthores();
        }
    }
}
