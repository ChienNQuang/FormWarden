namespace FormWarden.Forms
{
    partial class DeleteCategory
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
            saveBtn = new Button();
            cancelBtn = new Button();
            nameLbl = new Label();
            CategoryCbx = new ComboBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.MenuHighlight;
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(78, 129);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(97, 32);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(181, 129);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 32);
            cancelBtn.TabIndex = 17;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(107, 57);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(148, 15);
            nameLbl.TabIndex = 15;
            nameLbl.Text = "Choose category to delete.";
            // 
            // CategoryCbx
            // 
            CategoryCbx.FormattingEnabled = true;
            CategoryCbx.Location = new Point(119, 87);
            CategoryCbx.Name = "CategoryCbx";
            CategoryCbx.Size = new Size(121, 23);
            CategoryCbx.TabIndex = 19;
            // 
            // DeleteCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 203);
            Controls.Add(CategoryCbx);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(nameLbl);
            Name = "DeleteCategory";
            Text = "DeleteCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private Label nameLbl;
        private ComboBox CategoryCbx;
    }
}