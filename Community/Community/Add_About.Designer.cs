namespace Community
{
    partial class Add_About
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
            this.About_List = new System.Windows.Forms.ListBox();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneVProgressBar3 = new Siticone.Desktop.UI.WinForms.SiticoneVProgressBar();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.About_Text_Box = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // About_List
            // 
            this.About_List.BackColor = System.Drawing.Color.LimeGreen;
            this.About_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About_List.ColumnWidth = 3;
            this.About_List.Font = new System.Drawing.Font("Tahoma", 12F);
            this.About_List.FormattingEnabled = true;
            this.About_List.ItemHeight = 24;
            this.About_List.Items.AddRange(new object[] {
            "Available",
            "I Like Programming",
            "New Starter",
            "Working On A Project"});
            this.About_List.Location = new System.Drawing.Point(5, 146);
            this.About_List.Margin = new System.Windows.Forms.Padding(9);
            this.About_List.Name = "About_List";
            this.About_List.Size = new System.Drawing.Size(430, 480);
            this.About_List.Sorted = true;
            this.About_List.TabIndex = 56;
            this.About_List.SelectedIndexChanged += new System.EventHandler(this.About_List_SelectedIndexChanged);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Select About";
            // 
            // siticoneVProgressBar3
            // 
            this.siticoneVProgressBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.siticoneVProgressBar3.Location = new System.Drawing.Point(7, 108);
            this.siticoneVProgressBar3.Name = "siticoneVProgressBar3";
            this.siticoneVProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneVProgressBar3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneVProgressBar3.Size = new System.Drawing.Size(425, 2);
            this.siticoneVProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.siticoneVProgressBar3.TabIndex = 54;
            this.siticoneVProgressBar3.Text = "siticoneVProgressBar3";
            this.siticoneVProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Exit
            // 
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(420, 11);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(18, 18);
            this.Exit.TabIndex = 53;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(370, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ok";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 51;
            this.label1.Text = "Add About";
            // 
            // About_Text_Box
            // 
            this.About_Text_Box.BorderRadius = 18;
            this.About_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.About_Text_Box.DefaultText = "";
            this.About_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.About_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.About_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.About_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.About_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.About_Text_Box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.About_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.About_Text_Box.Location = new System.Drawing.Point(1, 66);
            this.About_Text_Box.Name = "About_Text_Box";
            this.About_Text_Box.PasswordChar = '\0';
            this.About_Text_Box.PlaceholderText = "";
            this.About_Text_Box.SelectedText = "";
            this.About_Text_Box.Size = new System.Drawing.Size(432, 36);
            this.About_Text_Box.TabIndex = 50;
            this.About_Text_Box.TextChanged += new System.EventHandler(this.About_Text_Box_TextChanged);
            // 
            // Add_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(443, 664);
            this.Controls.Add(this.About_List);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siticoneVProgressBar3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.About_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_About";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox About_List;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneVProgressBar siticoneVProgressBar3;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox About_Text_Box;
    }
}