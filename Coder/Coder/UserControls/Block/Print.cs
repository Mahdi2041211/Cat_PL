using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.UserControls.Block
{
    public partial class Print : DragableUC
    {
        public Print()
        {
            InitializeComponent();
        }

        private void Value_SizeChanged(object sender, EventArgs e)
        {
            Size = new Size(Value.Width + 15, Height);
            In.Location = new Point(Width / 2 - In.Width / 2, 0);
            Out.Location = new Point(Width / 2 - In.Width / 2, Height - In.Height);
        }
    }
}
