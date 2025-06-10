using Coder.UserControls;
using Coder.UserControls.Block;
using Coder.UserControls.ValueBlock;
using Microsoft.VisualBasic.ApplicationServices;
namespace Coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Files.WriteAllLines(@"C:\Users\DELL\OneDrive\Desktop\Try.txt", new string[] { "sdf", "345678", "cvbnm", "lkjhg" });
        }
    }
}
