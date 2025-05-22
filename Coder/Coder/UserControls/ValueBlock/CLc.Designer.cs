namespace Coder.UserControls.ValueBlock
{
    partial class CLc
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
            AddBtn = new Button();
            TypesList = new ComboBox();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(93, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(34, 23);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddOperatorAndValue;
            // 
            // TypesList
            // 
            TypesList.DisplayMember = "Number";
            TypesList.DropDownStyle = ComboBoxStyle.DropDownList;
            TypesList.FormattingEnabled = true;
            TypesList.Location = new Point(3, 4);
            TypesList.Name = "TypesList";
            TypesList.Size = new Size(84, 23);
            TypesList.TabIndex = 7;
            TypesList.SelectedIndexChanged += ChangeType;
            // 
            // CLc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            Controls.Add(TypesList);
            Controls.Add(AddBtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "CLc";
            Size = new Size(134, 56);
            ResumeLayout(false);
        }

        #endregion
        private Button AddBtn;
        private ComboBox TypesList;
    }
}
