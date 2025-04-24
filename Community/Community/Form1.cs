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
    public partial class Form1 : Form
    {
        public static bool IsVisible = false;
        int scaled = 0;
        Post post = new Post();

        public Form1()
        {
            InitializeComponent();
            show_posts();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Sizing_Click(object sender, EventArgs e)
        {
            if (scaled == 0)
            {
                WindowState = FormWindowState.Maximized;
                scaled = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                scaled = 0;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info.refresh();
        }

        private void add_About1_Load(object sender, EventArgs e)
        {

        }
        public static void visibility()
        {
            if (IsVisible)
            {
                Form1 form = new Form1();
                form.add_About1.Visible = true;
                IsVisible = false;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Add_Post add_Post = new Add_Post();
            add_Post.Show();
        }

        public  void show_posts()
        {
            if (this.PostsPanel.Controls.Count > 0)
                this.PostsPanel.Controls.RemoveAt(0);
            post.TopLevel = false;
            post.Dock = DockStyle.Top;
            this.PostsPanel.Controls.Add(post);
            this.PostsPanel.Tag = post;
            post.Show();
        }
        public void add_post()
        {
            if (this.PostsPanel.Controls.Count > 0)
                this.PostsPanel.Controls.RemoveAt(0);
            post.TopLevel = false;
            this.PostsPanel.Controls.Add(post);
            this.PostsPanel.Tag = post;
            post.Show();
        }

        private void PostsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
