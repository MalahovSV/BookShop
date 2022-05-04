
namespace BookShop
{
    partial class setupStringConnection
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
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.userNameSqlBox = new System.Windows.Forms.TextBox();
            this.passwordSqlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupUserDataSql = new System.Windows.Forms.GroupBox();
            this.vivsblePasswordCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.politicSqlBox = new System.Windows.Forms.ComboBox();
            this.dataBasesList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkConnectButton = new System.Windows.Forms.Button();
            this.WriteConnectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupUserDataSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverNameBox
            // 
            this.serverNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverNameBox.Location = new System.Drawing.Point(305, 65);
            this.serverNameBox.Margin = new System.Windows.Forms.Padding(6);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(385, 29);
            this.serverNameBox.TabIndex = 0;
            this.serverNameBox.TextChanged += new System.EventHandler(this.serverNameBox_TextChanged);
            // 
            // userNameSqlBox
            // 
            this.userNameSqlBox.Enabled = false;
            this.userNameSqlBox.Location = new System.Drawing.Point(243, 90);
            this.userNameSqlBox.Margin = new System.Windows.Forms.Padding(6);
            this.userNameSqlBox.Name = "userNameSqlBox";
            this.userNameSqlBox.Size = new System.Drawing.Size(385, 29);
            this.userNameSqlBox.TabIndex = 1;
            // 
            // passwordSqlBox
            // 
            this.passwordSqlBox.Enabled = false;
            this.passwordSqlBox.Location = new System.Drawing.Point(243, 131);
            this.passwordSqlBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordSqlBox.Name = "passwordSqlBox";
            this.passwordSqlBox.PasswordChar = '•';
            this.passwordSqlBox.Size = new System.Drawing.Size(385, 29);
            this.passwordSqlBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // groupUserDataSql
            // 
            this.groupUserDataSql.Controls.Add(this.vivsblePasswordCheck);
            this.groupUserDataSql.Controls.Add(this.label4);
            this.groupUserDataSql.Controls.Add(this.politicSqlBox);
            this.groupUserDataSql.Controls.Add(this.passwordSqlBox);
            this.groupUserDataSql.Controls.Add(this.label3);
            this.groupUserDataSql.Controls.Add(this.userNameSqlBox);
            this.groupUserDataSql.Controls.Add(this.label2);
            this.groupUserDataSql.Enabled = false;
            this.groupUserDataSql.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupUserDataSql.Location = new System.Drawing.Point(62, 121);
            this.groupUserDataSql.Name = "groupUserDataSql";
            this.groupUserDataSql.Size = new System.Drawing.Size(686, 221);
            this.groupUserDataSql.TabIndex = 6;
            this.groupUserDataSql.TabStop = false;
            this.groupUserDataSql.Text = "Вход на сервер";
            // 
            // vivsblePasswordCheck
            // 
            this.vivsblePasswordCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.vivsblePasswordCheck.AutoSize = true;
            this.vivsblePasswordCheck.BackColor = System.Drawing.Color.Gray;
            this.vivsblePasswordCheck.FlatAppearance.BorderSize = 0;
            this.vivsblePasswordCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.OliveDrab;
            this.vivsblePasswordCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vivsblePasswordCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vivsblePasswordCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vivsblePasswordCheck.Location = new System.Drawing.Point(449, 169);
            this.vivsblePasswordCheck.Name = "vivsblePasswordCheck";
            this.vivsblePasswordCheck.Size = new System.Drawing.Size(173, 34);
            this.vivsblePasswordCheck.TabIndex = 8;
            this.vivsblePasswordCheck.Text = "Показать пароль";
            this.vivsblePasswordCheck.UseVisualStyleBackColor = false;
            this.vivsblePasswordCheck.CheckedChanged += new System.EventHandler(this.vivsblePasswordCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Проверка подлинности";
            // 
            // politicSqlBox
            // 
            this.politicSqlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.politicSqlBox.FormattingEnabled = true;
            this.politicSqlBox.Items.AddRange(new object[] {
            "Проверка подлинности Windows",
            "Проверка подлинности SQL Server"});
            this.politicSqlBox.Location = new System.Drawing.Point(243, 49);
            this.politicSqlBox.Name = "politicSqlBox";
            this.politicSqlBox.Size = new System.Drawing.Size(385, 32);
            this.politicSqlBox.TabIndex = 6;
            this.politicSqlBox.SelectedIndexChanged += new System.EventHandler(this.politicSqlBox_SelectedIndexChanged);
            // 
            // dataBasesList
            // 
            this.dataBasesList.BackColor = System.Drawing.Color.White;
            this.dataBasesList.Enabled = false;
            this.dataBasesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBasesList.FormattingEnabled = true;
            this.dataBasesList.Location = new System.Drawing.Point(371, 372);
            this.dataBasesList.Name = "dataBasesList";
            this.dataBasesList.Size = new System.Drawing.Size(377, 32);
            this.dataBasesList.TabIndex = 7;
            this.dataBasesList.DropDown += new System.EventHandler(this.dataBasesList_DropDown);
            this.dataBasesList.SelectedIndexChanged += new System.EventHandler(this.dataBasesList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(58, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите или введите имя базы";
            // 
            // checkConnectButton
            // 
            this.checkConnectButton.BackColor = System.Drawing.Color.OliveDrab;
            this.checkConnectButton.Enabled = false;
            this.checkConnectButton.FlatAppearance.BorderSize = 0;
            this.checkConnectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.checkConnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.checkConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkConnectButton.Location = new System.Drawing.Point(62, 443);
            this.checkConnectButton.Name = "checkConnectButton";
            this.checkConnectButton.Size = new System.Drawing.Size(204, 60);
            this.checkConnectButton.TabIndex = 10;
            this.checkConnectButton.Text = "Показать строку соединения";
            this.checkConnectButton.UseVisualStyleBackColor = false;
            this.checkConnectButton.Click += new System.EventHandler(this.checkConnectButton_Click);
            // 
            // WriteConnectButton
            // 
            this.WriteConnectButton.BackColor = System.Drawing.Color.OliveDrab;
            this.WriteConnectButton.Enabled = false;
            this.WriteConnectButton.FlatAppearance.BorderSize = 0;
            this.WriteConnectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.WriteConnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.WriteConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WriteConnectButton.Location = new System.Drawing.Point(305, 443);
            this.WriteConnectButton.Name = "WriteConnectButton";
            this.WriteConnectButton.Size = new System.Drawing.Size(204, 60);
            this.WriteConnectButton.TabIndex = 11;
            this.WriteConnectButton.Text = "Подключиться";
            this.WriteConnectButton.UseVisualStyleBackColor = false;
            this.WriteConnectButton.Click += new System.EventHandler(this.WriteConnectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.OliveDrab;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(544, 443);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(204, 60);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // setupStringConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 539);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.WriteConnectButton);
            this.Controls.Add(this.checkConnectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBasesList);
            this.Controls.Add(this.groupUserDataSql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverNameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "setupStringConnection";
            this.Text = "Настройка соединения";
            this.groupUserDataSql.ResumeLayout(false);
            this.groupUserDataSql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.TextBox userNameSqlBox;
        private System.Windows.Forms.TextBox passwordSqlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupUserDataSql;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox politicSqlBox;
        private System.Windows.Forms.ComboBox dataBasesList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkConnectButton;
        private System.Windows.Forms.Button WriteConnectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox vivsblePasswordCheck;
    }
}