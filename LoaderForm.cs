using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class LoaderForm : Form
    {
        public LoaderForm(Task task)
        {
            InitializeComponent();
            LoadForm(task);
        }
        async private void LoadForm(Task task)
        {
            while (!task.IsCompleted)
            {
                
                if (textLoad.Text.Length < 11)
                {
                    textLoad.Text += ".";
                }
                else
                {
                    textLoad.Text = textLoad.Text.Substring(0, 8);
                }
                await Task.Delay(300);
            }
            if (task.IsFaulted)
            {
                textLoad.Text = task.Exception.Message;
            }
            else
            {
                this.Close();
            }
            
        }
        

    }
}
