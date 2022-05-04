
namespace BookShop
{
    partial class LoaderForm
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
            this.textLoad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textLoad
            // 
            this.textLoad.BackColor = System.Drawing.Color.DimGray;
            this.textLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.textLoad.Location = new System.Drawing.Point(5, 116);
            this.textLoad.Multiline = true;
            this.textLoad.Name = "textLoad";
            this.textLoad.ReadOnly = true;
            this.textLoad.Size = new System.Drawing.Size(469, 110);
            this.textLoad.TabIndex = 1;
            this.textLoad.Text = "Загрузка";
            this.textLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.textLoad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoaderForm";
            this.Text = "Соединение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLoad;
    }
}