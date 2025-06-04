using System;
using System.Collections;
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
    public partial class CLc : UserControl
    {
        CLc me;
        List<Control> values = new List<Control>();
        Type? myType = null;
        public Type? MyType { get { return myType; } }
        public List<Control> Values { get { return values; } }
        public ComboBox ChoseType { get { return TypesList; } }
        public CLc()
        {
            InitializeComponent();
            me = this;
            foreach (Type t in (Type[])Enum.GetValues(typeof(Type)))
                TypesList.Items.Add(t);
            ChangeType(new object(), new EventArgs());
            ComboBox NewValue = NewComboBox(new Point(4, 29));
        }
        string[] FillOperatorItems()
        {
            switch (myType)
            {
                case Type.Number:
                    return new string[] { "+", "-", "*", "/" };
                case Type.String: 
                    return new string[] { "+" };
                case Type.Bool:
                    return new string[] { "&&", "||" };
                default: return new string[0];
            }
        }

        void GetItems(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            combo.Items.Clear();
            switch (myType)
            {
                case Type.Number:
                case Type.String:
                    combo.Items.AddRange(Manager.GetVariablesByType((Type)myType));
                    break;
                case Type.Bool:
                    combo.Items.AddRange(Manager.GetVariablesByType((Type)myType));
                    combo.Items.AddRange( new string[]{ "True", "False" });
                    break;
            }
        }
        ComboBox NewComboBox(Point point)
        {
            ComboBox NewValue = new ComboBox();
            NewValue.Size = new Size(83, 23);
            NewValue.Leave += LeaveComboText;
            NewValue.Location = point;
            NewValue.DropDown += GetItems;
            if (myType == Type.Bool)
            {
                NewValue.DropDownStyle = ComboBoxStyle.DropDownList;
                NewValue.SelectedIndex = 0;
            }
            else if (myType == Type.Number) NewValue.Text = "0";
            Controls.Add(NewValue);
            values.Add(NewValue);
            return NewValue;
        }
        private void AddOperatorAndValue(object sender, EventArgs e)
        {
            ListBox operators = new ListBox();
            operators.Size = new Size(31, values.Last().Height + 10);
            operators.Location = new Point(values.Last().Location.X + values.Last().Width + 7, 30);
            operators.Items.AddRange(FillOperatorItems());
            values.Add(operators);
            Controls.Add(operators);
            ComboBox combo = NewComboBox(new Point(values.Last().Location.X + values.Last().Width + 7, 29));
            if (myType == Type.Bool) combo.DropDownStyle = ComboBoxStyle.DropDownList;
            AddBtn.Size = new Size(34, 23);
            me.Size = new Size(values.Last().Location.X + 5 + values.Last().Width, Height);
            AddBtn.Location = new Point(me.Width - 5 - AddBtn.Width, 4);
        }
        void LeaveComboText(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            switch (myType)
            {
                case Type.Number:
                    if (!(double.TryParse(comboBox.Text, out double IsDouble) || comboBox.Items.IndexOf(comboBox.Text) < 0))
                    {
                        MessageBox.Show("أدخل أرقاما فقط", "إدخال خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBox.Text = "0";
                    }
                    break;
                case Type.Bool:
                    if (comboBox.Items.IndexOf(comboBox.Text) < 0)
                        MessageBox.Show("أدخل القيمة المنطقية", "إدخال خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox.Text = comboBox.Items[0].ToString(); break;
            }
        }

        private void ChangeType(object sender, EventArgs e)
        {
            if (myType == null)
            {
                TypesList.SelectedIndex = 0;
                myType = 0;
            }
            else if (TypesList.SelectedIndex != (int)myType)
            {
                DialogResult dialog = MessageBox.Show("هل أنت متأكد أنك تريد تغيير النوع؟", "تأكيد التغيير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    myType = (Type)TypesList.SelectedIndex;
                    for (int i = 0; i < values.Count; i++)
                        Controls.Remove(values[i]);
                    values.Clear();
                    ComboBox combo = NewComboBox(new Point(4, 29));
                    me.Size = new Size(values.Last().Width + values.Last().Location.X + 10 + AddBtn.Width, Height);
                    AddBtn.Location = new Point(me.Size.Width - 5 - AddBtn.Width, 4);
                    Controls.Add(AddBtn);
                }
                else myType = (Type)myType;
            }
        }
        public enum Type { Number = 0, String = 1, Bool = 2 }
    }
}
