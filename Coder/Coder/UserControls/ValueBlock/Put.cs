using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.UserControls.ValueBlock
{
    public partial class Put : UserControl
    {
        Type type;
        [Browsable(true)]
        public Type MyType
        {
            get { return type; }
            set
            {
                type = value;
                _ = type == Type.In ? BackColor = Color.LightGreen : BackColor = Color.LightBlue;
            }
        }
        public Control MyControl {  get; set; }
        public Put(Type type, Control control) : base()
        {
            this.MyType = type;
            MyControl = control;
        }
        public Put()
        {
            InitializeComponent();
            MyType = Type.In;
            BackColor = Color.LightGreen;
        }
        public enum Type { In = 0, Out = 1 };
    }
}
