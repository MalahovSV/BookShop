using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UserControls
{
    public partial class PanelBook : UserControl
    {
        public PanelBook()
        {
            InitializeComponent();
        }

        private void PanelBook_MouseEnter(object sender, EventArgs e)
        {
            setUpColor();
        }

        private void PanelBook_MouseLeave(object sender, EventArgs e)
        {
            setDefaultColor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void setUpColor()
        {
            this.BackColor = Color.OliveDrab;
        }
        private void setDefaultColor()
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            setUpColor();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            setDefaultColor();
        }
    }
}
