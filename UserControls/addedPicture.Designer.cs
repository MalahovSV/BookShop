
namespace BookShop.UserControls
{
    partial class addedPicture
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectImageButton = new System.Windows.Forms.Button();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.namePicture = new System.Windows.Forms.TextBox();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImageButton
            // 
            this.selectImageButton.BackColor = System.Drawing.Color.OliveDrab;
            this.selectImageButton.FlatAppearance.BorderSize = 0;
            this.selectImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.selectImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.selectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectImageButton.Location = new System.Drawing.Point(87, 388);
            this.selectImageButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(534, 56);
            this.selectImageButton.TabIndex = 2;
            this.selectImageButton.Text = "Открыть картинку";
            this.selectImageButton.UseVisualStyleBackColor = false;
            this.selectImageButton.Click += new System.EventHandler(this.onSelectImageBook);
            // 
            // openPicture
            // 
            this.openPicture.FileName = "picture";
            this.openPicture.Filter = "Image files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif";
            // 
            // namePicture
            // 
            this.namePicture.Location = new System.Drawing.Point(326, 73);
            this.namePicture.Margin = new System.Windows.Forms.Padding(6);
            this.namePicture.Name = "namePicture";
            this.namePicture.Size = new System.Drawing.Size(295, 29);
            this.namePicture.TabIndex = 1;
            // 
            // pictureBook
            // 
            this.pictureBook.BackColor = System.Drawing.Color.White;
            this.pictureBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBook.Location = new System.Drawing.Point(87, 114);
            this.pictureBook.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.Size = new System.Drawing.Size(534, 262);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBook.TabIndex = 1;
            this.pictureBook.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование картинки";
            // 
            // addPictureButton
            // 
            this.addPictureButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addPictureButton.FlatAppearance.BorderSize = 0;
            this.addPictureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.addPictureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPictureButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPictureButton.Location = new System.Drawing.Point(238, 453);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(227, 99);
            this.addPictureButton.TabIndex = 3;
            this.addPictureButton.Text = "Добавить картинку в БД";
            this.addPictureButton.UseVisualStyleBackColor = false;
            this.addPictureButton.Click += new System.EventHandler(this.onAddPictureButton);
            // 
            // addedPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.addPictureButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namePicture);
            this.Controls.Add(this.pictureBook);
            this.Controls.Add(this.selectImageButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addedPicture";
            this.Text = "Добавление картинки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.PictureBox pictureBook;
        private System.Windows.Forms.OpenFileDialog openPicture;
        private System.Windows.Forms.TextBox namePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPictureButton;
    }
}
