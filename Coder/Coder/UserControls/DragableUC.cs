using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.UserControls
{
    public partial class DragableUC : UserControl
    {
        private bool isDragging = false;
        private Point dragStartPoint;
        public Type MyType;

        public DragableUC()
        {
            InitializeComponent();
        }

        private void DragableUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void DragableUC_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = this.PointToScreen(e.Location);
                Point parentClientPos = this.Parent.PointToClient(currentScreenPos);

                this.Location = new Point(
                    parentClientPos.X - dragStartPoint.X,
                    parentClientPos.Y - dragStartPoint.Y
                );
            }
        }

        private void DragableUC_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                this.Cursor = Cursors.Default;
            }
        }
        public enum Type { Set, If, Loop, Print }
    }
}
