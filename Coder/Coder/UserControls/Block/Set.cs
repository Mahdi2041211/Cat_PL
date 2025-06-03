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
    public partial class Set : DragableUC
    {
        public Set()
        {
            InitializeComponent();
            In.Location = new Point(this.Width / 2 - In.Width / 2, 0);
            Out.Location = new Point(this.Width / 2 - Out.Width / 2, this.Height - Out.Height);
            In.ParentControl = this;
            Out.ParentControl = this;
        }

        private void Value_SizeChanged(object sender, EventArgs e)
        {
            Size = new Size(Value.Width + Value.Location.X + 5, Height);
            Out.Location = new Point(this.Width / 2 - Out.Width / 2, this.Height - Out.Height);
            In.Location = new Point(this.Width / 2 - In.Width / 2, 0);
            Controls.Add(In);
            Controls.Add(Out);
        }

        private void VarName_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Variable Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            VarName.Focus();
        }
        string name = "";
        private void Set_Leave(object sender, EventArgs e)
        {
            if (VarName.Text == "")
            {
                MessageBox.Show("Enter Variable Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VarName.Focus();
            }
            else
            {
                Variable variable = new Variable();
                switch (Value.MyType)
                {
                    case ValueBlock.CLc.Type.Number:
                        variable.Type = ValueBlock.CLc.Type.Number; break;
                    case ValueBlock.CLc.Type.String:
                        variable.Type = ValueBlock.CLc.Type.String; break;
                    case ValueBlock.CLc.Type.Bool:
                        variable.Type = ValueBlock.CLc.Type.Bool; break;
                }
                variable.Value = Value.Values;
                if (name != VarName.Text) Manager.Variables.Remove(name);
                name = VarName.Text;
                if (Manager.Variables.TryGetValue(name, out Variable temp))
                {
                    if (temp.Type != variable.Type)
                    {
                        MessageBox.Show("لا يمكنك تغيير نوع متحول موجود فعلا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Value.ChoseType.SelectedItem = variable.Type;
                    }
                    else temp = variable;
                }
                else Manager.Variables.Add(name, variable);
            }
        }
    }
}
