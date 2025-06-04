namespace Coder.UserControls.ValueBlock
{
    partial class Condition
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
            AddConditionBtn = new Button();
            SuspendLayout();
            // 
            // AddConditionBtn
            // 
            AddConditionBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddConditionBtn.Location = new Point(357, 14);
            AddConditionBtn.Name = "AddConditionBtn";
            AddConditionBtn.Size = new Size(65, 36);
            AddConditionBtn.TabIndex = 9;
            AddConditionBtn.Text = "Add";
            AddConditionBtn.UseVisualStyleBackColor = true;
            AddConditionBtn.Click += AddConditionBtn_Click;
            // 
            // Condition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddConditionBtn);
            Name = "Condition";
            Size = new Size(429, 66);
            ResumeLayout(false);
        }

        #endregion
        private Button AddConditionBtn;
    }
}
