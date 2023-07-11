namespace FormWarden
{
    partial class CreateIdentity
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtUri = new TextBox();
            label6 = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 14);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(65, 129);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 23);
            txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(318, 110);
            label4.Name = "label4";
            label4.Size = new Size(54, 14);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(318, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 180);
            label5.Name = "label5";
            label5.Size = new Size(22, 14);
            label5.TabIndex = 9;
            label5.Text = "Uri";
            // 
            // txtUri
            // 
            txtUri.Location = new Point(65, 199);
            txtUri.Name = "txtUri";
            txtUri.Size = new Size(205, 23);
            txtUri.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(65, 246);
            label6.Name = "label6";
            label6.Size = new Size(36, 14);
            label6.TabIndex = 11;
            label6.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(65, 281);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(458, 23);
            txtNotes.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(65, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(183, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 32);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateIdentity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUri);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "CreateIdentity";
            Text = "New item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtUri;
        private Label label6;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
    }
}