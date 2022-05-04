using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UserControls
{
    public partial class AddedBook : UserControl
    {
        SqlConnection conn = new SqlConnection();
        DataTable listGenre = new DataTable();
        public AddedBook(SqlConnection connection)
        {
            InitializeComponent();
            Console.WriteLine("Form AddedBook: " + connection.State);
            conn = connection;
            loadGenre();
            loadAuthores();
            publishingHouses();
        }

        private void loadGenre()
        {
            listGenre = Classes.DBUtils.loadDataTableAuthorization($@"sp_Get_Name_Genres", conn);

            foreach(DataRow row in listGenre.Rows)
            {
                GenreGrid.Rows.Add(row.ItemArray[0].ToString());
            }
        }

        public void loadAuthores()
        {
            AuthorComboBox.DataSource = Classes.DBUtils.loadDataTableAuthorization("sp_Get_Surname_First_Name_Author", conn);
            AuthorComboBox.DisplayMember = "Автор";
            AuthorComboBox.ValueMember = "PK_author";
        }
        private void publishingHouses()
        {
            PublishingHouseCombo.DataSource = Classes.DBUtils.loadDataTableAuthorization("sp_Get_Name_Publishing_House", conn);
            PublishingHouseCombo.DisplayMember = "name_PH";
            PublishingHouseCombo.ValueMember = "PK_publicshing_house";
        }


        private TableLayoutPanel createPanelGenre(string Genre)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel()
            {
                RowCount = 1,
                ColumnCount = 2,
                Width = 800,
                Height = 100,
                BackColor = Color.OliveDrab
            };
            Label nameGenre = new Label()
            {
                Text = Genre,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
            };
            nameGenre.Width = Genre.Length > 20? (Genre.Length * 10) : (Genre.Length * 5) + 100; //Расчет ширины лэйбла
                
            tableLayout.Controls.Add(nameGenre, 0, 0);
            Button butt = new Button() 
            { 
                Text = "X",
                Width = 30,
                Height = 30,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            butt.FlatAppearance.MouseDownBackColor = Color.Red;
            butt.FlatAppearance.MouseOverBackColor = Color.Red;
            
            butt.Click += (s, e) =>
            {
                GenreGrid.Rows.Add(nameGenre.Text);
                tableLayout.Dispose(); //Delete conteiner
            };
            tableLayout.Controls.Add(butt, 1, 0);
            tableLayout.AutoSize = true;
            return tableLayout;
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addedGenres.Controls.Add(createPanelGenre(GenreGrid.SelectedCells[0].Value.ToString()));
            GenreGrid.Rows.Remove(GenreGrid.CurrentRow);
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            if (checkDataInTextBoxes()) //если поля не пусты
            {
                if(addedGenres.Controls.Count > 1) // Если есть тэги
                {
                    if (nameImage.Text != "Наименование изображения") //если есть изображение
                        try 
                        {
                            AddedRecordInDataBase(); //Добавить изображение
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        MessageBox.Show("Выберите изображение!", "Ошибка заполнения", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите тэги", "Ошибка заполнения", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка заполнения", MessageBoxButtons.OK);
            }
        }

        private bool checkDataInTextBoxes()
        {
            bool flag = true;
            if (NameBook.Text.Length < 1)
            {
                flag = false;
            }
            if (yearBook.Text.Length < 1)
            {
                flag = false;
            }
            if (Price.Text.Length < 1)
            {
                flag = false;
            }
            if (AuthorComboBox.Text.Length < 1)
            {
                flag = false;
            }
            if (PublishingHouseCombo.Text.Length < 1)
            {
                flag = false;
            }
            return flag;
        }

        private void AddedRecordInDataBase()
        {
            string SqlCommand = $@"insert into books values (
                                                                '{NameBook.Text}',
                                                                {yearBook.Text},
                                                                {Price.Text},
                                                                {AuthorComboBox.SelectedValue}, 
                                                                {PublishingHouseCombo.SelectedValue},
                                                                {IdImage}
                                                                )";
            Classes.DBUtils.ExecuteNonQuerySqlCommand(SqlCommand, conn);
            Console.WriteLine("[InsertCommand]: {0, 70}", SqlCommand);


            int id = (int)(Classes.DBUtils.loadDataTableAuthorization($@"select pk_book from books where 
                                                                name_book = '{NameBook.Text}' and
                                                                year_book = {yearBook.Text} and
                                                                price = {Price.Text.Replace(",", ".")} and
                                                                fk_author = {AuthorComboBox.SelectedValue} and 
                                                                fk_publishing_house = {PublishingHouseCombo.SelectedValue} and
                                                                fk_image = {IdImage}", conn)).Rows[0].ItemArray[0];
            Console.WriteLine("[Record ID]: {0, 40}", id);
            foreach (TableLayoutPanel panel in addedGenres.Controls)
            {
                Console.WriteLine($@"  [GenreItem]: insert into genres_book values ({id}, (select pk_genre from genre where name_genre = '{panel.Controls[0].Text}')) {0,70}", panel.Controls[0].Text);

                Classes.DBUtils.ExecuteNonQuerySqlCommand($@"insert into genres_book values ( (select pk_genre from genre where name_genre = '{panel.Controls[0].Text}'), {id})", conn);
            }
            MessageBox.Show("Запись добавлена", "Успешно", MessageBoxButtons.OK);
        }

        private void AuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(AuthorComboBox.SelectedValue.ToString());
        }

        private void NewImage_Click(object sender, EventArgs e)
        {
            addedPicture addedPicture = new addedPicture(conn);
            addedPicture.ShowDialog();
        }
        public string IdImage;
        private void SearchImage_Click(object sender, EventArgs e)
        {
            ImageForm imgForm = new ImageForm(conn, this);
            imgForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            NameBook.Text = "";
            yearBook.Text = "";
            Price.Text = "";
            loadGenre();
            addedGenres.Controls.Clear();
            if (nameImage.Text != "Наименование изображения")
                ImageBook.Image.Dispose();
            nameImage.Text = "Наименование изображения";
            
        }

        private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorTable authorTable = new AuthorTable(conn, this);
            authorTable.ShowDialog();
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void yearBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void linlPublishHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PublishingHouseTable publishingHouseTable = new PublishingHouseTable(conn, this);
            publishingHouseTable.ShowDialog();
        }
    }
}
