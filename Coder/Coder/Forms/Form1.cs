using Coder.UserControls;
using Coder.UserControls.Block;
using Coder.UserControls.ValueBlock;
namespace Coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("you Leaved");
        }

        private void set1_Click(object sender, EventArgs e)
        {
            set1.Focus();
        }

        private void set1_Leave_1(object sender, EventArgs e)
        {
            MessageBox.Show("Enter The Variable Name!", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void set1_Leave_2(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Manager.Variables.Keys)
                listBox1.Items.Add(item);
        }

        private void set2_Leave(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Manager.Variables.Keys)
                listBox1.Items.Add(item);
        }
    }
}
