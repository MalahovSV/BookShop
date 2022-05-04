
namespace BookShop.UserControls
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.NewsButton = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dropSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagesGrid
            // 
            this.ImagesGrid.AllowUserToAddRows = false;
            this.ImagesGrid.AllowUserToDeleteRows = false;
            this.ImagesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImagesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Image});
            this.ImagesGrid.Location = new System.Drawing.Point(13, 84);
            this.ImagesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagesGrid.Name = "ImagesGrid";
            this.ImagesGrid.ReadOnly = true;
            this.ImagesGrid.RowHeadersWidth = 10;
            this.ImagesGrid.RowTemplate.Height = 180;
            this.ImagesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ImagesGrid.Size = new System.Drawing.Size(825, 563);
            this.ImagesGrid.TabIndex = 15;
            this.ImagesGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImagesGrid_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.FillWeight = 300F;
            this.Image.HeaderText = "Картинка";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NewsButton
            // 
            this.NewsButton.BackColor = System.Drawing.Color.OliveDrab;
            this.NewsButton.FlatAppearance.BorderSize = 0;
            this.NewsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.NewsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.NewsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewsButton.Location = new System.Drawing.Point(851, 84);
            this.NewsButton.Margin = new System.Windows.Forms.Padding(9);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(294, 62);
            this.NewsButton.TabIndex = 17;
            this.NewsButton.Text = "Выбрать";
            this.NewsButton.UseVisualStyleBackColor = false;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // imageName
            // 
            this.imageName.Location = new System.Drawing.Point(209, 25);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(248, 26);
            this.imageName.TabIndex = 19;
            this.imageName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Поиск по наименованию";
            // 
            // dropSelect
            // 
            this.dropSelect.BackColor = System.Drawing.Color.OliveDrab;
            this.dropSelect.FlatAppearance.BorderSize = 0;
            this.dropSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.dropSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.dropSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.dropSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dropSelect.Location = new System.Drawing.Point(469, 18);
            this.dropSelect.Margin = new System.Windows.Forms.Padding(9);
            this.dropSelect.Name = "dropSelect";
            this.dropSelect.Size = new System.Drawing.Size(170, 43);
            this.dropSelect.TabIndex = 21;
            this.dropSelect.Text = "Сбросить";
            this.dropSelect.UseVisualStyleBackColor = false;
            this.dropSelect.Click += new System.EventHandler(this.dropSelect_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dropSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.NewsButton);
            this.Controls.Add(this.ImagesGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageForm";
            this.Text = "Выбор изображения";
            ((System.ComponentModel.ISupportInitialize)(this.ImagesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImagesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.TextBox imageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dropSelect;
    }
}