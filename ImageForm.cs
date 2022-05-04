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
    public partial class ImageForm : Form
    {
        string select = $@"select * from images";
        SqlConnection sqlConnection = new SqlConnection();
        AddedBook addedBook;
        public ImageForm(SqlConnection connection, AddedBook addedBook)
        {
            InitializeComponent();
            this.addedBook = addedBook;
            sqlConnection = connection;
            loadImages(sqlConnection, select);
        }


        private void loadImages(SqlConnection conn, string select)
        {
            ImagesGrid.Rows.Clear();
            byte[] ImageCar;
            Stream stream;
            Bitmap bitmap;

            DataTable imagesTable = Classes.DBUtils.loadDataTableAuthorization(
                select, conn);
            foreach (DataRow row in imagesTable.Rows)
            {
                ImageCar = (byte[])row.ItemArray[2];
                stream = new MemoryStream(ImageCar);
                bitmap = new Bitmap(stream);
                ImagesGrid.Rows.Add(row.ItemArray[0], row.ItemArray[1], bitmap);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            select = $@"select * from images where name_image like '%{imageName.Text}%'";
            loadImages(sqlConnection, select);
        }

        private void dropSelect_Click(object sender, EventArgs e)
        {
            imageName.Text = "";
            select = $@"select * from images";
            loadImages(sqlConnection, select);
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            if (ImagesGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Не выбрано ни одной строки.", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                addedBook.IdImage = ImagesGrid.SelectedRows[0].Cells[0].Value.ToString();
                addedBook.nameImage.Text = ImagesGrid.SelectedRows[0].Cells[1].Value.ToString();
                addedBook.ImageBook.Image = (Image)ImagesGrid.SelectedRows[0].Cells[2].Value;
                this.Close();
            }
        }
        
        private void ImagesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ImagesGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Не выбрано ни одной строки.", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                addedBook.IdImage = ImagesGrid.SelectedRows[0].Cells[0].Value.ToString();
                addedBook.nameImage.Text = ImagesGrid.SelectedRows[0].Cells[1].Value.ToString();
                addedBook.ImageBook.Image = (Image)ImagesGrid.SelectedRows[0].Cells[2].Value;
                this.Close();
            }
        }
    }
}
