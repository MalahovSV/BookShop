
namespace BookShop.UserControls
{
    partial class Catalogs
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
            this.splitControl = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.genresMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.booksPanels = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).BeginInit();
            this.splitControl.Panel1.SuspendLayout();
            this.splitControl.Panel2.SuspendLayout();
            this.splitControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitControl
            // 
            this.splitControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControl.Location = new System.Drawing.Point(0, 0);
            this.splitControl.Margin = new System.Windows.Forms.Padding(6);
            this.splitControl.Name = "splitControl";
            // 
            // splitControl.Panel1
            // 
            this.splitControl.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitControl.Panel2
            // 
            this.splitControl.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.splitControl.Panel2.Controls.Add(this.booksPanels);
            this.splitControl.Size = new System.Drawing.Size(1315, 617);
            this.splitControl.SplitterDistance = 282;
            this.splitControl.SplitterWidth = 7;
            this.splitControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.12134F));
            this.tableLayoutPanel1.Controls.Add(this.genresMenuPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 615);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // genresMenuPanel
            // 
            this.genresMenuPanel.AutoScroll = true;
            this.genresMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.genresMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genresMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.genresMenuPanel.Location = new System.Drawing.Point(6, 6);
            this.genresMenuPanel.Margin = new System.Windows.Forms.Padding(6);
            this.genresMenuPanel.Name = "genresMenuPanel";
            this.genresMenuPanel.Size = new System.Drawing.Size(268, 603);
            this.genresMenuPanel.TabIndex = 0;
            this.genresMenuPanel.WrapContents = false;
            this.genresMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.genresMenuPanel_Paint);
            // 
            // booksPanels
            // 
            this.booksPanels.AutoScroll = true;
            this.booksPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksPanels.Location = new System.Drawing.Point(0, 0);
            this.booksPanels.Name = "booksPanels";
            this.booksPanels.Size = new System.Drawing.Size(1024, 615);
            this.booksPanels.TabIndex = 0;
            // 
            // Catalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.splitControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Catalogs";
            this.Size = new System.Drawing.Size(1315, 617);
            this.splitControl.Panel1.ResumeLayout(false);
            this.splitControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).EndInit();
            this.splitControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel genresMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel booksPanels;
    }
}
