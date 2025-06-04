using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.UserControls.ValueBlock
{
    public partial class Put : UserControl
    {
        DragableUC TargetBlock;
        public DragableUC ParentControl { get; set; }
        [Browsable(true)]
        public DragableUC.Type ReferenceBlockType
        {
            get { return TargetBlock.MyType; }
            set
            {
                TargetBlock.MyType = value;
            }
        }
        public Put()
        {
            InitializeComponent();
        }
        public enum Type { In = 0, Out = 1 };

        private void Put_Click(object sender, EventArgs e)
        {
            
        }
    }
}
