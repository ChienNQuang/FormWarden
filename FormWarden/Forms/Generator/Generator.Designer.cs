namespace FormWarden.Forms.Generator
{
    partial class Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.rbPassword = new System.Windows.Forms.RadioButton();
            this.gbPasswordType = new System.Windows.Forms.GroupBox();
            this.rbPassphrase = new System.Windows.Forms.RadioButton();
            this.rbTypePassword = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.cbLowerCase = new System.Windows.Forms.CheckBox();
            this.cbSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.gbPasswordType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generator";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(22, 70);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(451, 23);
            this.txtResult.TabIndex = 1;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbUsername);
            this.gbType.Controls.Add(this.rbPassword);
            this.gbType.Location = new System.Drawing.Point(22, 114);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(200, 47);
            this.gbType.TabIndex = 2;
            this.gbType.TabStop = false;
            this.gbType.Text = "What would you like to generate";
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Location = new System.Drawing.Point(104, 22);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(78, 19);
            this.rbUsername.TabIndex = 1;
            this.rbUsername.TabStop = true;
            this.rbUsername.Text = "Username";
            this.rbUsername.UseVisualStyleBackColor = true;
            this.rbUsername.CheckedChanged += new System.EventHandler(this.rbUsername_CheckedChanged);
            // 
            // rbPassword
            // 
            this.rbPassword.AutoSize = true;
            this.rbPassword.Location = new System.Drawing.Point(6, 22);
            this.rbPassword.Name = "rbPassword";
            this.rbPassword.Size = new System.Drawing.Size(75, 19);
            this.rbPassword.TabIndex = 0;
            this.rbPassword.TabStop = true;
            this.rbPassword.Text = "Password";
            this.rbPassword.UseVisualStyleBackColor = true;
            this.rbPassword.CheckedChanged += new System.EventHandler(this.rbPassword_CheckedChanged);
            // 
            // gbPasswordType
            // 
            this.gbPasswordType.Controls.Add(this.rbPassphrase);
            this.gbPasswordType.Controls.Add(this.rbTypePassword);
            this.gbPasswordType.Location = new System.Drawing.Point(22, 188);
            this.gbPasswordType.Name = "gbPasswordType";
            this.gbPasswordType.Size = new System.Drawing.Size(200, 48);
            this.gbPasswordType.TabIndex = 3;
            this.gbPasswordType.TabStop = false;
            this.gbPasswordType.Text = "PasswordType";
            // 
            // rbPassphrase
            // 
            this.rbPassphrase.AutoSize = true;
            this.rbPassphrase.Location = new System.Drawing.Point(104, 22);
            this.rbPassphrase.Name = "rbPassphrase";
            this.rbPassphrase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPassphrase.Size = new System.Drawing.Size(83, 19);
            this.rbPassphrase.TabIndex = 1;
            this.rbPassphrase.TabStop = true;
            this.rbPassphrase.Text = "Passphrase";
            this.rbPassphrase.UseVisualStyleBackColor = true;
            // 
            // rbTypePassword
            // 
            this.rbTypePassword.AutoSize = true;
            this.rbTypePassword.Location = new System.Drawing.Point(6, 22);
            this.rbTypePassword.Name = "rbTypePassword";
            this.rbTypePassword.Size = new System.Drawing.Size(75, 19);
            this.rbTypePassword.TabIndex = 0;
            this.rbTypePassword.TabStop = true;
            this.rbTypePassword.Text = "Password";
            this.rbTypePassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(72, 266);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(197, 23);
            this.txtLength.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Options";
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Location = new System.Drawing.Point(22, 344);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(46, 19);
            this.cbUpperCase.TabIndex = 7;
            this.cbUpperCase.Text = "A-Z";
            this.cbUpperCase.UseVisualStyleBackColor = true;
            // 
            // cbLowerCase
            // 
            this.cbLowerCase.AutoSize = true;
            this.cbLowerCase.Location = new System.Drawing.Point(22, 382);
            this.cbLowerCase.Name = "cbLowerCase";
            this.cbLowerCase.Size = new System.Drawing.Size(42, 19);
            this.cbLowerCase.TabIndex = 8;
            this.cbLowerCase.Text = "a-z";
            this.cbLowerCase.UseVisualStyleBackColor = true;
            // 
            // cbSpecialCharacters
            // 
            this.cbSpecialCharacters.AutoSize = true;
            this.cbSpecialCharacters.Location = new System.Drawing.Point(22, 419);
            this.cbSpecialCharacters.Name = "cbSpecialCharacters";
            this.cbSpecialCharacters.Size = new System.Drawing.Size(76, 19);
            this.cbSpecialCharacters.TabIndex = 9;
            this.cbSpecialCharacters.Text = "!@#$%^&*";
            this.cbSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(445, 344);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(139, 68);
            this.btGenerate.TabIndex = 10;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(609, 344);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(134, 68);
            this.btCopy.TabIndex = 11;
            this.btCopy.Text = "Copy";
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.cbSpecialCharacters);
            this.Controls.Add(this.cbLowerCase);
            this.Controls.Add(this.cbUpperCase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPasswordType);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Name = "Generator";
            this.Text = "Generator";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbPasswordType.ResumeLayout(false);
            this.gbPasswordType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtResult;
        private GroupBox gbType;
        private RadioButton rbUsername;
        private RadioButton rbPassword;
        private GroupBox gbPasswordType;
        private RadioButton rbPassphrase;
        private RadioButton rbTypePassword;
        private Label label2;
        private TextBox txtLength;
        private Label label3;
        private CheckBox cbUpperCase;
        private CheckBox cbLowerCase;
        private CheckBox cbSpecialCharacters;
        private Button btGenerate;
        private Button btCopy;
    }
}