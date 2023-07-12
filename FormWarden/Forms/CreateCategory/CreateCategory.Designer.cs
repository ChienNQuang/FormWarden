namespace FormWarden.Forms
{
    partial class CreateCategory
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
            categoryNameTxt = new TextBox();
            nameLbl = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.MenuHighlight;
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(97, 145);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(97, 32);
            saveBtn.TabIndex = 22;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(200, 145);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 32);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(146, 103);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(100, 23);
            categoryNameTxt.TabIndex = 20;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(136, 73);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(120, 15);
            nameLbl.TabIndex = 19;
            nameLbl.Text = "Input category name.";
            // 
            // CreateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 245);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(categoryNameTxt);
            Controls.Add(nameLbl);
            Name = "CreateCategory";
            Text = "CreateCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private TextBox categoryNameTxt;
        private Label nameLbl;
    }
}