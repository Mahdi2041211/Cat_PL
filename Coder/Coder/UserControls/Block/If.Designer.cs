namespace Coder.UserControls.Block
{
    partial class If : DragableUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            In = new Coder.UserControls.ValueBlock.Put();
            True = new Coder.UserControls.ValueBlock.Put();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(8, 10);
            Title.Name = "Title";
            Title.Size = new Size(28, 25);
            Title.TabIndex = 0;
            Title.Text = "IF";
            // 
            // In
            // 
            In.BackColor = Color.Yellow;
            In.Location = new Point(185, -1);
            In.Name = "In";
            In.ParentControl = null;
            In.Size = new Size(22, 21);
            In.TabIndex = 1;
            // 
            // True
            // 
            True.BackColor = Color.Lime;
            True.Location = new Point(-1, 54);
            True.Name = "True";
            True.ParentControl = null;
            True.Size = new Size(22, 21);
            True.TabIndex = 2;
            // 
            // If
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(True);
            Controls.Add(In);
            Controls.Add(Title);
            Name = "If";
            Size = new Size(410, 146);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ValueBlock.Put In;
        private ValueBlock.Put True;
    }
}
