namespace Coder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            set1 = new Coder.UserControls.Block.Set();
            listBox1 = new ListBox();
            set2 = new Coder.UserControls.Block.Set();
            SuspendLayout();
            // 
            // set1
            // 
            set1.BorderStyle = BorderStyle.FixedSingle;
            set1.Location = new Point(171, 84);
            set1.Name = "set1";
            set1.Size = new Size(269, 102);
            set1.TabIndex = 0;
            set1.Leave += set1_Leave_2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 304);
            listBox1.TabIndex = 2;
            // 
            // set2
            // 
            set2.BorderStyle = BorderStyle.FixedSingle;
            set2.Location = new Point(171, 246);
            set2.Name = "set2";
            set2.Size = new Size(269, 102);
            set2.TabIndex = 3;
            set2.Leave += set2_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(set2);
            Controls.Add(listBox1);
            Controls.Add(set1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.Block.Set set1;
        private ListBox listBox1;
        private UserControls.Block.Set set2;
    }
}
