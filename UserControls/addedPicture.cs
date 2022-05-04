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
    public partial class addedPicture : Form
    {
        SqlConnection connection = new SqlConnection();
        public addedPicture(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void onSelectImageBook(object sender, EventArgs e)
        {
            if (openPicture.ShowDialog() == DialogResult.Cancel)
                return;
            selectImageButton.Text = openPicture.FileName;
            FileStream file = File.Open(selectImageButton.Text, FileMode.Open);
            pictureBook.Image = Image.FromStream(file);
            file.Close();
        }

        private void onAddPictureButton(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("addedPicture form: " + connection.State);
                if (namePicture.Text.Length > 0 || selectImageButton.Text.Length > 0)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO images VALUES (@name_image, @Image_data)";
                    command.Parameters.Add("@name_image", SqlDbType.NVarChar);


                    // массив для хранения бинарных данных файла
                    byte[] imageData;
                    using (FileStream fs = new FileStream(selectImageButton.Text, FileMode.Open))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, imageData.Length);
                        command.Parameters.Add("@Image_data", SqlDbType.Image, Convert.ToInt32(imageData.Length));
                    }
                    // передаем данные в команду через параметры
                    command.Parameters["@name_image"].Value = namePicture.Text;
                    command.Parameters["@Image_data"].Value = imageData;

                    command.ExecuteNonQuery();
                    Console.WriteLine("Image saved.");
                    MessageBox.Show("Изображение добавлено.", "Сообщение", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка заполнения", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
