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

    public partial class PublishingHouseTable : Form
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        AddedBook ParentUserControl;
        DataTable PublishingHouseDataTable = new DataTable();
        SqlConnection sqlConnection;
        public PublishingHouseTable(SqlConnection sqlConnection, AddedBook addedBook)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            ParentUserControl = addedBook;
            CreateCommandDataAdapter();
            loadDataInTable();
            
        }

        private void CreateCommandDataAdapter()
        {

            #region InsertComand
            dataAdapter.InsertCommand = new SqlCommand(" insert into publicshing_house (name_PH, Address_PH, number_phone, email) values(@name_PH, @Address_PH, @number_phone, @email)", sqlConnection);

            dataAdapter.InsertCommand.Parameters.Add("@name_PH", SqlDbType.VarChar, 0, "Наименование");
            dataAdapter.InsertCommand.Parameters.Add("@Address_PH", SqlDbType.VarChar, 0, "Адрес");
            dataAdapter.InsertCommand.Parameters.Add("@number_phone", SqlDbType.VarChar, 0, "Телефон");
            dataAdapter.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 30, "Почта");
            #endregion

            #region UpdateCommand
            dataAdapter.UpdateCommand = new SqlCommand(@"update  publicshing_house set 
                                                        name_PH = @name_PH, 
                                                        Address_PH = @Address_PH, 
                                                        number_phone = @number_phone, 
                                                        email = @email
                                                        where PK_publicshing_house = @PK_publicshing_house", sqlConnection);
            dataAdapter.UpdateCommand.Parameters.Add("@PK_publicshing_house", SqlDbType.Int, 0, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@name_PH", SqlDbType.VarChar, 0, "Наименование");
            dataAdapter.UpdateCommand.Parameters.Add("@Address_PH", SqlDbType.VarChar, 0, "Адрес");
            dataAdapter.UpdateCommand.Parameters.Add("@number_phone", SqlDbType.VarChar, 0, "Телефон");
            dataAdapter.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 30, "Почта");
            #endregion

            #region DeleteCommand
            dataAdapter.DeleteCommand = new SqlCommand("delete from publicshing_house where PK_publicshing_house = @PK_publicshing_house", sqlConnection);
            dataAdapter.DeleteCommand.Parameters.Add("@PK_publicshing_house", SqlDbType.Int, 0, "ID");
            #endregion
        }

        private void loadDataInTable()
        {
            dataGridPublishingHouse.Refresh();
            PublishingHouseDataTable = Classes.DBUtils.loadDataTableAuthorization(@"select PK_publicshing_house as 'ID', name_PH as 'Наименование', 
Address_PH as 'Адрес', number_phone as 'Телефон', email as 'Почта' from publicshing_house", sqlConnection);

            dataGridPublishingHouse.DataSource = PublishingHouseDataTable;
            dataGridPublishingHouse.Columns[0].ReadOnly = true;
        }

        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                dataAdapter.Update(PublishingHouseDataTable);
                //Classes.DBUtils.ExecuteNonQuerySqlCommand("SET IDENTITY_INSERT publicshing_house ON;", sqlConnection);
                Console.WriteLine("[INFO] {0, 50}", "PublishingHouseDataTable update succefully");
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
    }
}
