using Siticone.Desktop.UI.WinForms;
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
    public partial class Add_Post : Form
    {
        public static Add_Post AddPost;
        public SiticoneTextBox PostTextBox;
        Form1 Form1 = new Form1();
        public Add_Post()
        {
            InitializeComponent();
            AddPost = this;
            PostTextBox = PostBox;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (PostTextBox != null)
            {
                Post.post.label.Text = PostTextBox.Text;
                Form1.add_post();
            }
        }
    }
}
