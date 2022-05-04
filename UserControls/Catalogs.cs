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
    public partial class Catalogs : UserControl
    {
        string select = $@"select name_book, year_book as 'Год издания', price as 'Цена', 
Concat(first_name, ' ', surname) as 'Автор',  
image_data
from books, genre, genres_book, Author, images
where pk_book = FK_Book and fk_genre = PK_genre and PK_author = fk_author and fk_image = PK_image  ";
        string groupBy = " group by name_book, year_book, price, surname, first_name, second_name, image_data";
        SqlConnection connection = new SqlConnection();
        public Catalogs(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            loadGenres();
            loadPanelsBooks(select + groupBy);
        }

        private void loadPanelsBooks( string select)
        {
            if (booksPanels.Controls.Count > 0)
                booksPanels.Controls.Clear();
            DataTable dt = Classes.DBUtils.loadDataTableAuthorization(
                select,
                connection);
            foreach(DataRow row in dt.Rows)
            {
                booksPanels.Controls.Add(
                createPanelsBook(row.ItemArray[0].ToString(), 
                                 row.ItemArray[1].ToString(), 
                                 row.ItemArray[2].ToString(), 
                                 row.ItemArray[3].ToString(), 
                                 (byte[])row.ItemArray[4])
                );
            }
        }
        /// <summary>
        /// Создание панели с книгой
        /// </summary>
        /// <param name="nameBook">Имя книги</param>
        /// <param name="yearBook">Год издания</param>
        /// <param name="price">Цена</param>
        /// <param name="author">Автор</param>
        /// <param name="imageData">Изображение</param>
        /// <returns>Панель с изображением книги</returns>
        private PanelBook createPanelsBook(string nameBook, string yearBook, string price, string author, byte[] imageData)
        {
            PanelBook pb = new PanelBook();
            pb.nameBook.Text = $"{nameBook}\n{author}\n{price} р.";

            byte[] ImageBook = imageData;
            Stream stream = new MemoryStream(ImageBook);
            var bitmap = new Bitmap(stream);
            pb.PictureBook.Image = bitmap;

            return pb;
        }
        
        

        /// <summary>
        /// Загрузка тэгов с жанрами
        /// </summary>
        private void loadGenres()
        {
            Console.WriteLine("Catalogs form: " + connection.State);
            DataTable dt = Classes.DBUtils.loadDataTableAuthorization(
                $@"select * from genre order by name_genre asc",
                connection);

            foreach (DataRow row in dt.Rows)
            {
                createCheckBox(row.ItemArray[1].ToString());
            }
        }
        /// <summary>
        /// Создание тэгов по жанрам
        /// </summary>
        /// <param name="nameCheckBox">Текст на CheckBox`е</param>
        private void createCheckBox(string nameCheckBox)
        {
            CheckBox check = new CheckBox()
            {
                Text = nameCheckBox,
                FlatStyle = FlatStyle.Flat,
                Appearance = Appearance.Button,
                ForeColor = Color.White,
                Height = 40,
                AutoSize = true
            };
            check.FlatAppearance.CheckedBackColor = Color.OliveDrab;
            check.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            check.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);

            check.Click += (s, e) =>
            {
                string subString = $@" and name_genre = '{check.Text}'";
                if (check.Checked)
                {
                    select += subString;
                    loadPanelsBooks(select + groupBy);
                }
                if(!check.Checked)
                {
                    int indexForDelFromSelect = select.IndexOf(subString);
                    select = select.Remove(indexForDelFromSelect, subString.Length);
                    loadPanelsBooks(select + groupBy);

                }
                Console.WriteLine(select);
            };
            genresMenuPanel.Controls.Add(check);
        }

        private void genresMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
