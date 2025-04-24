using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community
{
    public partial class info : UserControl
    {
        string about;
        public static info info1;
        public Label lbl;
        public Image[] images;
        public info()
        {
            InitializeComponent();
            info1 = this;
            lbl = About1;
        }

        private void Edit_about_Click(object sender, EventArgs e)
        {
            Add_About add_About = new Add_About();
            add_About.Show();
        }

        public void refresh()
        {
            //To Show The Posts Of The User.
            string about1 = About1.Text;
            if (this.PostsPanel.Controls.Count > 0)
                this.PostsPanel.Controls.RemoveAt(0);
            Post post = new Post();
            post.TopLevel = false;
            post.Dock = DockStyle.Top;
            post.Size = new Size(PostsPanel.Width, 100);
            this.PostsPanel.Controls.Add(post);
            this.PostsPanel.Tag = post;
            post.Show();

            //To make The Bio Good.
        }
        private void Edit_name_Click(object sender, EventArgs e)
        {
            Rename.Visible = true;
        }

        private void Rename_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(Rename.Text))
                    Name_label.Text = "~.";
                else
                    Name_label.Text = Rename.Text;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "images(*.png;*.jpg;*.jpeg)|*.png||*.jpg";
            open.Title = "select a file";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string name = open.FileName;
                images = new Image[]
                {
                    Image.FromFile(name)
                };
                Photo.Image = images[0];
                Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PostsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
