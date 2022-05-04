
namespace BookShop.UserControls
{
    partial class PanelBook
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
            this.PictureBook = new System.Windows.Forms.PictureBox();
            this.nameBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBook)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBook
            // 
            this.PictureBook.Location = new System.Drawing.Point(0, 3);
            this.PictureBook.Margin = new System.Windows.Forms.Padding(30);
            this.PictureBook.Name = "PictureBook";
            this.PictureBook.Size = new System.Drawing.Size(280, 242);
            this.PictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBook.TabIndex = 5;
            this.PictureBook.TabStop = false;
            this.PictureBook.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PictureBook.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.PictureBook.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // nameBook
            // 
            this.nameBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameBook.Location = new System.Drawing.Point(0, 247);
            this.nameBook.Name = "nameBook";
            this.nameBook.Size = new System.Drawing.Size(280, 153);
            this.nameBook.TabIndex = 6;
            this.nameBook.Text = "Наименование книги";
            this.nameBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameBook.MouseEnter += new System.EventHandler(this.PanelBook_MouseEnter);
            this.nameBook.MouseLeave += new System.EventHandler(this.PanelBook_MouseLeave);
            // 
            // PanelBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.nameBook);
            this.Controls.Add(this.PictureBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PanelBook";
            this.Size = new System.Drawing.Size(280, 400);
            this.MouseEnter += new System.EventHandler(this.PanelBook_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PanelBook_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBook;
        public System.Windows.Forms.Label nameBook;
    }
}
