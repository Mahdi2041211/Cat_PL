namespace Coder.UserControls.Block
{
    partial class Print : DragableUC
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
            Value = new Coder.UserControls.ValueBlock.CLc();
            In = new Coder.UserControls.ValueBlock.Put();
            Out = new Coder.UserControls.ValueBlock.Put();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(6, 7);
            Title.Name = "Title";
            Title.Size = new Size(44, 21);
            Title.TabIndex = 0;
            Title.Text = "Print";
            // 
            // Value
            // 
            Value.BackColor = Color.DarkOrange;
            Value.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Value.Location = new Point(6, 40);
            Value.Margin = new Padding(0);
            Value.Name = "Value";
            Value.Size = new Size(134, 56);
            Value.TabIndex = 1;
            Value.SizeChanged += Value_SizeChanged;
            // 
            // In
            // 
            In.BackColor = Color.Cyan;
            In.Location = new Point(66, 0);
            In.Name = "In";
            In.ParentControl = null;
            In.Size = new Size(22, 21);
            In.TabIndex = 2;
            // 
            // Out
            // 
            Out.BackColor = Color.Lime;
            Out.Location = new Point(66, 99);
            Out.Name = "Out";
            Out.ParentControl = null;
            Out.Size = new Size(22, 21);
            Out.TabIndex = 3;
            // 
            // Print
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Out);
            Controls.Add(In);
            Controls.Add(Value);
            Controls.Add(Title);
            Name = "Print";
            Size = new Size(149, 118);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ValueBlock.CLc Value;
        private ValueBlock.Put In;
        private ValueBlock.Put Out;
    }
}
