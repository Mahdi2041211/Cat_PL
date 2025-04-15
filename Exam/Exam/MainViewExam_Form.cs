using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace Exam
{
    public partial class MainViewExam_Form : Form
    {
        static bool winForms = false;
        static int number_qes = 0;
        static int x_qes = 155, y_qes = 20;
        Guna2Button ButtonAddQes = new Guna2Button();



        public MainViewExam_Form()
        {
            InitializeComponent();
            PublishQestion();
            PublishComoboxExan();
            ButtonAddQes.Click += button_Click;
        }


        private void MainViewExam_Form_Load(object sender, EventArgs e)
        {

        }



        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        // حدث لتحريك الفورم مع تغيير الشفافية

        public void PublishQestion()
        {
          
          
            for (int i = 0; i < 5; i++)
            {

                Question question = new Question();
                question.Size = new Size(843, 805);
                question.Location = new Point(x_qes, y_qes);
                y_qes += question.Height+30;
                question.guna2HtmlLabel5.Text = $"{++number_qes}";
                panelshadow_qes.Controls.Add(question);
                
            }
            ButtonAddQes.Size = new Size(50, 50);
            ButtonAddQes.FillColor = Color.Green;
            ButtonAddQes.Text = "Add Qes";
            ButtonAddQes.Location = new Point(x_qes, y_qes + 20);
            panelshadow_qes.Controls.Add(ButtonAddQes);

        }
        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {

                Question question = new Question();
                question.Size = new Size(843, 805);
                question.Location = new Point(x_qes, y_qes);
                y_qes += question.Height + 30;
                question.guna2HtmlLabel5.Text = $"{++number_qes}";
                panelshadow_qes.Controls.Add(question);

            }
            ButtonAddQes.Size = new Size(50, 50);
            ButtonAddQes.FillColor = Color.Green;
            ButtonAddQes.Text = "Add Qes";
            ButtonAddQes.Location = new Point(x_qes, y_qes + 20);
            panelshadow_qes.Controls.Add(ButtonAddQes);
        }

        public void PublishComoboxExan()
        {

            int X = 6;
            int y = 50;
            for (int i = 1; i < 11; i++)
            {

                ComoboxViewExam comoboxViewExam = new ComoboxViewExam();
                comoboxViewExam.Location = new Point(X, y);
                comoboxViewExam.Size = new Size(562, 389);
                X += comoboxViewExam.Width + 5;

                if (i % 3 == 0 && this.WindowState == FormWindowState.Maximized || i % 2 == 0 && this.WindowState == FormWindowState.Normal)
                {
                    y += comoboxViewExam.Height + 30;
                    X = 6;

                }
                DoExam_tappage.Controls.Add(comoboxViewExam);
            }


        }
        public void Windowstate(Guna2CircleButton guna2CircleButton)
        {

            if (guna2CircleButton.FillColor == Color.Red)
            {

                Application.Exit();

            }

            if (guna2CircleButton.FillColor == Color.Yellow)
                this.WindowState = FormWindowState.Minimized;

            if (guna2CircleButton.FillColor == Color.Blue)
            {
                if (winForms == false)
                {
                    this.WindowState = FormWindowState.Maximized;
                    winForms = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    winForms = false;
                }
            }
        }
        private void MainViewExam_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //this.Opacity = 0.8; // خفض الشفافية عند الإمساك بالفورم
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }
        private void guna2TabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //this.Opacity = 0.8; // خفض الشفافية عند الإمساك بالفورم
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }

        private void buttonWinForm1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void guna2TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void MainViewExam_Form_Click(object sender, EventArgs e)
        {

        }

        private void MainViewExam_Form_Click_1(object sender, EventArgs e)
        {

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWinForm5_Load(object sender, EventArgs e)
        {

        }

        private void Level_Lable_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void comoboxViewExam1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonWinForm2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Separator6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panelshadow_qes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



