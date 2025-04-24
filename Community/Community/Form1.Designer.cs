namespace Community
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.Hide = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.Sizing = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PostsPanel = new System.Windows.Forms.Panel();
            this.info = new Community.info();
            this.searching2 = new Community.Searching();
            this.add_About1 = new Community.Add_About();
            this.siticoneContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.BorderRadius = 10;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockForm = false;
            this.siticoneBorderlessForm1.DockIndicatorColor = System.Drawing.Color.Red;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ShadowColor = System.Drawing.Color.Yellow;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.Transparent;
            this.Hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.Hide.FillColor = System.Drawing.Color.DodgerBlue;
            this.Hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Hide.ForeColor = System.Drawing.Color.White;
            this.Hide.Location = new System.Drawing.Point(1295, 0);
            this.Hide.Name = "Hide";
            this.Hide.Padding = new System.Windows.Forms.Padding(1);
            this.Hide.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.Hide.ShadowDecoration.Enabled = true;
            this.Hide.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.Hide.Size = new System.Drawing.Size(38, 38);
            this.Hide.TabIndex = 9;
            this.Hide.Text = "_";
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Sizing
            // 
            this.Sizing.BackColor = System.Drawing.Color.Transparent;
            this.Sizing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sizing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sizing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sizing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sizing.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sizing.FillColor = System.Drawing.Color.Lime;
            this.Sizing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sizing.ForeColor = System.Drawing.Color.White;
            this.Sizing.Location = new System.Drawing.Point(1333, 0);
            this.Sizing.Name = "Sizing";
            this.Sizing.Padding = new System.Windows.Forms.Padding(1);
            this.Sizing.ShadowDecoration.Color = System.Drawing.Color.Lime;
            this.Sizing.ShadowDecoration.Enabled = true;
            this.Sizing.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.Sizing.Size = new System.Drawing.Size(38, 38);
            this.Sizing.TabIndex = 10;
            this.Sizing.Text = "O";
            this.Sizing.Click += new System.EventHandler(this.Sizing_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FillColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1371, 0);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(1);
            this.Exit.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.Exit.ShadowDecoration.Enabled = true;
            this.Exit.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(38, 38);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.Hide);
            this.siticoneContainerControl1.Controls.Add(this.Sizing);
            this.siticoneContainerControl1.Controls.Add(this.Exit);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.YellowGreen;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(1409, 38);
            this.siticoneContainerControl1.TabIndex = 15;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 20;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.Image = global::Community.Properties.Resources._211878_plus_icon;
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.siticoneButton1.Location = new System.Drawing.Point(419, 38);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(563, 45);
            this.siticoneButton1.TabIndex = 19;
            this.siticoneButton1.Text = "Add A Post";
            this.siticoneButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // PostsPanel
            // 
            this.PostsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostsPanel.Location = new System.Drawing.Point(419, 83);
            this.PostsPanel.Name = "PostsPanel";
            this.PostsPanel.Size = new System.Drawing.Size(563, 726);
            this.PostsPanel.TabIndex = 20;
            this.PostsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PostsPanel_Paint);
            // 
            // info
            // 
            this.info.AutoScroll = true;
            this.info.BackColor = System.Drawing.Color.LimeGreen;
            this.info.Dock = System.Windows.Forms.DockStyle.Right;
            this.info.Location = new System.Drawing.Point(982, 38);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(427, 771);
            this.info.TabIndex = 17;
            // 
            // searching2
            // 
            this.searching2.BackColor = System.Drawing.Color.LimeGreen;
            this.searching2.Dock = System.Windows.Forms.DockStyle.Left;
            this.searching2.Location = new System.Drawing.Point(0, 38);
            this.searching2.Name = "searching2";
            this.searching2.Size = new System.Drawing.Size(419, 771);
            this.searching2.TabIndex = 16;
            // 
            // add_About1
            // 
            this.add_About1.BackColor = System.Drawing.Color.LimeGreen;
            this.add_About1.ClientSize = new System.Drawing.Size(446, 594);
            this.add_About1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.add_About1.Location = new System.Drawing.Point(7590, 194);
            this.add_About1.Name = "add_About1";
            this.add_About1.Text = "Form2";
            this.add_About1.Visible = false;
            this.add_About1.Load += new System.EventHandler(this.add_About1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1409, 809);
            this.Controls.Add(this.PostsPanel);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.searching2);
            this.Controls.Add(this.siticoneContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton Exit;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton Sizing;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton Hide;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Searching searching2;
        private info info;
        private Add_About add_About1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Panel PostsPanel;
    }
}

