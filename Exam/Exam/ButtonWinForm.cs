using Guna.UI2.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class ButtonWinForm : UserControl
    {
        static bool winform = false;
        public ButtonWinForm()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Normal)
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
                winform = true;
            }
            else
            {
                this.ParentForm.WindowState = FormWindowState.Normal;
                winform = false;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
