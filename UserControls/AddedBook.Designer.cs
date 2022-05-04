
namespace BookShop.UserControls
{
    partial class AddedBook
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
            this.NameBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.GenreGrid = new System.Windows.Forms.DataGridView();
            this.name_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PublishingHouseCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutGenres = new System.Windows.Forms.TableLayoutPanel();
            this.addedGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutText = new System.Windows.Forms.TableLayoutPanel();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.linlPublishHome = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameImage = new System.Windows.Forms.Label();
            this.ImageBook = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewImage = new System.Windows.Forms.Button();
            this.SearchImage = new System.Windows.Forms.Button();
            this.ClearImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GenreGrid)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutGenres.SuspendLayout();
            this.tableLayoutText.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBook)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBook
            // 
            this.NameBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBook.Location = new System.Drawing.Point(374, 3);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(281, 26);
            this.NameBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(151, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(822, 733);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(169, 47);
            this.InsertRecordButton.TabIndex = 4;
            this.InsertRecordButton.Text = "Добавить запись";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // GenreGrid
            // 
            this.GenreGrid.AllowUserToAddRows = false;
            this.GenreGrid.AllowUserToDeleteRows = false;
            this.GenreGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenreGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_genre});
            this.GenreGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreGrid.Location = new System.Drawing.Point(3, 38);
            this.GenreGrid.MultiSelect = false;
            this.GenreGrid.Name = "GenreGrid";
            this.GenreGrid.ReadOnly = true;
            this.GenreGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GenreGrid.Size = new System.Drawing.Size(684, 193);
            this.GenreGrid.TabIndex = 5;
            this.GenreGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // name_genre
            // 
            this.name_genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_genre.HeaderText = "Жанр";
            this.name_genre.Name = "name_genre";
            this.name_genre.ReadOnly = true;
            // 
            // yearBook
            // 
            this.yearBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yearBook.Location = new System.Drawing.Point(374, 41);
            this.yearBook.Name = "yearBook";
            this.yearBook.Size = new System.Drawing.Size(281, 26);
            this.yearBook.TabIndex = 6;
            this.yearBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBook_KeyPress);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(151, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Год издательства";
            // 
            // PublishingHouseCombo
            // 
            this.PublishingHouseCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublishingHouseCombo.FormattingEnabled = true;
            this.PublishingHouseCombo.Location = new System.Drawing.Point(374, 155);
            this.PublishingHouseCombo.Name = "PublishingHouseCombo";
            this.PublishingHouseCombo.Size = new System.Drawing.Size(281, 28);
            this.PublishingHouseCombo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(151, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(151, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "Издательства";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(151, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // Price
            // 
            this.Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price.Location = new System.Drawing.Point(374, 79);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(281, 26);
            this.Price.TabIndex = 12;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutGenres, 0, 2);
            this.tableLayoutMain.Controls.Add(this.tableLayoutText, 0, 1);
            this.tableLayoutMain.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 5;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1382, 800);
            this.tableLayoutMain.TabIndex = 15;
            // 
            // tableLayoutGenres
            // 
            this.tableLayoutGenres.ColumnCount = 2;
            this.tableLayoutGenres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2052F));
            this.tableLayoutGenres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7948F));
            this.tableLayoutGenres.Controls.Add(this.GenreGrid, 0, 1);
            this.tableLayoutGenres.Controls.Add(this.addedGenres, 1, 1);
            this.tableLayoutGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutGenres.Location = new System.Drawing.Point(3, 227);
            this.tableLayoutGenres.Name = "tableLayoutGenres";
            this.tableLayoutGenres.RowCount = 2;
            this.tableLayoutGenres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04425F));
            this.tableLayoutGenres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.95575F));
            this.tableLayoutGenres.Size = new System.Drawing.Size(1376, 234);
            this.tableLayoutGenres.TabIndex = 15;
            // 
            // addedGenres
            // 
            this.addedGenres.AutoScroll = true;
            this.addedGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.addedGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addedGenres.Location = new System.Drawing.Point(693, 38);
            this.addedGenres.Name = "addedGenres";
            this.addedGenres.Size = new System.Drawing.Size(680, 193);
            this.addedGenres.TabIndex = 6;
            // 
            // tableLayoutText
            // 
            this.tableLayoutText.ColumnCount = 5;
            this.tableLayoutText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81082F));
            this.tableLayoutText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tableLayoutText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tableLayoutText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.tableLayoutText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.81081F));
            this.tableLayoutText.Controls.Add(this.label1, 1, 0);
            this.tableLayoutText.Controls.Add(this.PublishingHouseCombo, 2, 4);
            this.tableLayoutText.Controls.Add(this.Price, 2, 2);
            this.tableLayoutText.Controls.Add(this.AuthorComboBox, 2, 3);
            this.tableLayoutText.Controls.Add(this.label5, 1, 2);
            this.tableLayoutText.Controls.Add(this.label4, 1, 4);
            this.tableLayoutText.Controls.Add(this.label2, 1, 1);
            this.tableLayoutText.Controls.Add(this.yearBook, 2, 1);
            this.tableLayoutText.Controls.Add(this.label3, 1, 3);
            this.tableLayoutText.Controls.Add(this.NameBook, 2, 0);
            this.tableLayoutText.Controls.Add(this.linkAuthor, 3, 3);
            this.tableLayoutText.Controls.Add(this.linlPublishHome, 3, 4);
            this.tableLayoutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutText.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutText.Name = "tableLayoutText";
            this.tableLayoutText.RowCount = 5;
            this.tableLayoutText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutText.Size = new System.Drawing.Size(1376, 194);
            this.tableLayoutText.TabIndex = 16;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(374, 117);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(281, 28);
            this.AuthorComboBox.TabIndex = 8;
            this.AuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorComboBox_SelectedIndexChanged);
            // 
            // linkAuthor
            // 
            this.linkAuthor.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkAuthor.Location = new System.Drawing.Point(671, 114);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Size = new System.Drawing.Size(128, 20);
            this.linkAuthor.TabIndex = 14;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "Редактировать";
            this.linkAuthor.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthor_LinkClicked);
            // 
            // linlPublishHome
            // 
            this.linlPublishHome.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.linlPublishHome.AutoSize = true;
            this.linlPublishHome.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linlPublishHome.Location = new System.Drawing.Point(671, 152);
            this.linlPublishHome.Name = "linlPublishHome";
            this.linlPublishHome.Size = new System.Drawing.Size(128, 20);
            this.linlPublishHome.TabIndex = 15;
            this.linlPublishHome.TabStop = true;
            this.linlPublishHome.Text = "Редактировать";
            this.linlPublishHome.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linlPublishHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlPublishHome_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InsertButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 707);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1376, 90);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.OliveDrab;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.InsertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsertButton.Location = new System.Drawing.Point(6, 6);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(6);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(279, 58);
            this.InsertButton.TabIndex = 6;
            this.InsertButton.Text = "Добавить запись";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(297, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отчистить всё";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.nameImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImageBook, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 467);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1376, 234);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // nameImage
            // 
            this.nameImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameImage.Location = new System.Drawing.Point(3, 0);
            this.nameImage.Name = "nameImage";
            this.nameImage.Size = new System.Drawing.Size(452, 234);
            this.nameImage.TabIndex = 8;
            this.nameImage.Text = "Наименование изображения";
            this.nameImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageBook
            // 
            this.ImageBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBook.Location = new System.Drawing.Point(461, 3);
            this.ImageBook.Name = "ImageBook";
            this.ImageBook.Size = new System.Drawing.Size(452, 228);
            this.ImageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBook.TabIndex = 0;
            this.ImageBook.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.NewImage);
            this.flowLayoutPanel2.Controls.Add(this.SearchImage);
            this.flowLayoutPanel2.Controls.Add(this.ClearImage);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(919, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(454, 228);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // NewImage
            // 
            this.NewImage.BackColor = System.Drawing.Color.OliveDrab;
            this.NewImage.FlatAppearance.BorderSize = 0;
            this.NewImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.NewImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.NewImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.NewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewImage.Location = new System.Drawing.Point(6, 6);
            this.NewImage.Margin = new System.Windows.Forms.Padding(6);
            this.NewImage.Name = "NewImage";
            this.NewImage.Size = new System.Drawing.Size(279, 58);
            this.NewImage.TabIndex = 5;
            this.NewImage.Text = "Добавить новое изображение";
            this.NewImage.UseVisualStyleBackColor = false;
            this.NewImage.Click += new System.EventHandler(this.NewImage_Click);
            // 
            // SearchImage
            // 
            this.SearchImage.BackColor = System.Drawing.Color.OliveDrab;
            this.SearchImage.FlatAppearance.BorderSize = 0;
            this.SearchImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.SearchImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.SearchImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.SearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchImage.Location = new System.Drawing.Point(6, 76);
            this.SearchImage.Margin = new System.Windows.Forms.Padding(6);
            this.SearchImage.Name = "SearchImage";
            this.SearchImage.Size = new System.Drawing.Size(279, 58);
            this.SearchImage.TabIndex = 4;
            this.SearchImage.Text = "Найти картинку";
            this.SearchImage.UseVisualStyleBackColor = false;
            this.SearchImage.Click += new System.EventHandler(this.SearchImage_Click);
            // 
            // ClearImage
            // 
            this.ClearImage.BackColor = System.Drawing.Color.OliveDrab;
            this.ClearImage.FlatAppearance.BorderSize = 0;
            this.ClearImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.LawnGreen;
            this.ClearImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.ClearImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.ClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearImage.Location = new System.Drawing.Point(6, 146);
            this.ClearImage.Margin = new System.Windows.Forms.Padding(6);
            this.ClearImage.Name = "ClearImage";
            this.ClearImage.Size = new System.Drawing.Size(279, 58);
            this.ClearImage.TabIndex = 6;
            this.ClearImage.Text = "Отчистить";
            this.ClearImage.UseVisualStyleBackColor = false;
            // 
            // AddedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.InsertRecordButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddedBook";
            this.Size = new System.Drawing.Size(1382, 800);
            ((System.ComponentModel.ISupportInitialize)(this.GenreGrid)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutGenres.ResumeLayout(false);
            this.tableLayoutText.ResumeLayout(false);
            this.tableLayoutText.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBook)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.DataGridView GenreGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_genre;
        private System.Windows.Forms.TextBox yearBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PublishingHouseCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGenres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutText;
        private System.Windows.Forms.FlowLayoutPanel addedGenres;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button NewImage;
        private System.Windows.Forms.Button SearchImage;
        private System.Windows.Forms.Button ClearImage;
        public System.Windows.Forms.PictureBox ImageBook;
        public System.Windows.Forms.Label nameImage;
        private System.Windows.Forms.LinkLabel linkAuthor;
        private System.Windows.Forms.LinkLabel linlPublishHome;
        public System.Windows.Forms.ComboBox AuthorComboBox;
    }
}
