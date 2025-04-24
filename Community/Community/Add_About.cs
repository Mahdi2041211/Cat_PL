using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community
{
    public partial class Add_About : Form
    {
        public static Add_About about;
        public Add_About()
        {
            InitializeComponent();
            about = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(About_Text_Box.Text))
            {
                if (!About_List.Items.Contains(About_Text_Box.Text))
                {
                    About_List.Items.Add(About_Text_Box.Text);
                    info.info1.lbl.Text = About_Text_Box.Text;
                }
                else
                {
                    info.info1.lbl.Text = About_Text_Box.Text;
                }
            }
        }

        private void About_Text_Box_TextChanged(object sender, EventArgs e)
        {
        }

        private void About_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (About_List.SelectedIndex >= 0)
                About_Text_Box.Text = About_List.SelectedItem.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


