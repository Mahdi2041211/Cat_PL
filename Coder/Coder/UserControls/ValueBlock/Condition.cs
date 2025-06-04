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
    public partial class Condition : UserControl
    {
        List<Control> Conditions = new List<Control>();
        public Condition()
        {
            InitializeComponent();
            CLc cLc1 = new CLc(), clc2 = new CLc();
            cLc1.Location = new Point(11, 4);
            ListBox listBox = new ListBox();
            listBox.Location = new Point(157, 22);
            listBox.Items.AddRange(new string[] { "==", "<=", ">=", "!=" });
            listBox.Size = new Size(39, 19);
            clc2.Location = new Point(208, 4);
            Conditions.AddRange(new Control[] { cLc1, listBox, clc2 });
            Controls.AddRange(new Control[] {cLc1, listBox, clc2 });
        }

        private void AddConditionBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Height += 60;
            ListBox AndOr = new ListBox();
            AndOr.Location = button.Location;
            AndOr.Size = new Size(65, 40);
            AndOr.Font = new Font(Font.FontFamily, 14, FontStyle.Bold);
            AndOr.Items.AddRange(new string[] { "And", "OR" });
            AndOr.MouseUp += AndOrMouseUp;
            button.Location = new Point(button.Location.X, button.Location.Y + 70);
            Controls.Add(AndOr);

        }
        void AndOrMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                menuStrip.Items.AddRange(new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("إزالة")
                });
                menuStrip.Show(this, PointToClient(Cursor.Position));
                menuStrip.Items[0].Click += DeleteClick;
            }
        }
        void DeleteClick(object sender, EventArgs e)
        {

        }
    }
}
