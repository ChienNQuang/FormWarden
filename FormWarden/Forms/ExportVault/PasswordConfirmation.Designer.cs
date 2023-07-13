namespace FormWarden.Forms
{
    partial class PasswordConfirmation
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
            label1 = new Label();
            txtPassword = new TextBox();
            btnConfirm = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 97);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(171, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.ActiveCaption;
            btnConfirm.Location = new Point(132, 143);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 56);
            label2.Name = "label2";
            label2.Size = new Size(230, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter your password to confirm exporting:";
            // 
            // PasswordConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 278);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "PasswordConfirmation";
            Text = "PasswordConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button btnConfirm;
        private Label label2;
    }
}