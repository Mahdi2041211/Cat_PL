namespace Coder.UserControls.Block
{
    partial class Set : DragableUC
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
            TitleLabel = new Label();
            VarName = new ComboBox();
            In = new Coder.UserControls.ValueBlock.Put();
            label1 = new Label();
            Value = new Coder.UserControls.ValueBlock.CLc();
            Out = new Coder.UserControls.ValueBlock.Put();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(34, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Set";
            // 
            // VarName
            // 
            VarName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VarName.FormattingEnabled = true;
            VarName.Location = new Point(4, 34);
            VarName.Name = "VarName";
            VarName.Size = new Size(96, 29);
            VarName.TabIndex = 1;
            // 
            // In
            // 
            In.BackColor = Color.LightBlue;
            In.Location = new Point(106, 0);
            In.ParentControl = null;
            In.Name = "In";
            In.Size = new Size(19, 21);
            In.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 37);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // Value
            // 
            Value.BackColor = Color.DarkOrange;
            Value.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Value.Location = new Point(130, 24);
            Value.Margin = new Padding(0);
            Value.Name = "Value";
            Value.Size = new Size(134, 56);
            Value.TabIndex = 4;
            Value.SizeChanged += Value_SizeChanged;
            // 
            // Out
            // 
            Out.BackColor = Color.LightGreen;
            Out.Location = new Point(106, 83);
            Out.ParentControl = null;
            Out.Name = "Out";
            Out.Size = new Size(22, 18);
            Out.TabIndex = 5;
            // 
            // Set
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Out);
            Controls.Add(Value);
            Controls.Add(label1);
            Controls.Add(In);
            Controls.Add(VarName);
            Controls.Add(TitleLabel);
            Name = "Set";
            Size = new Size(269, 102);
            Leave += Set_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private ComboBox VarName;
        private ValueBlock.Put In;
        private Label label1;
        private ValueBlock.CLc Value;
        private ValueBlock.Put Out;
    }
}
