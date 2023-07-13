namespace FormWarden.Forms
{
    partial class ExportVault
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
            cbFileFormat = new ComboBox();
            label1 = new Label();
            btnConfirm = new Button();
            chkEncrypted = new CheckBox();
            SuspendLayout();
            // 
            // cbFileFormat
            // 
            cbFileFormat.FormattingEnabled = true;
            cbFileFormat.Location = new Point(57, 101);
            cbFileFormat.Name = "cbFileFormat";
            cbFileFormat.Size = new Size(169, 23);
            cbFileFormat.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "File format";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.MenuHighlight;
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(57, 176);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(116, 35);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm format";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // chkEncrypted
            // 
            chkEncrypted.AutoSize = true;
            chkEncrypted.Location = new Point(57, 139);
            chkEncrypted.Name = "chkEncrypted";
            chkEncrypted.Size = new Size(79, 19);
            chkEncrypted.TabIndex = 3;
            chkEncrypted.Text = "Encrypted";
            chkEncrypted.UseVisualStyleBackColor = true;
            // 
            // ExportVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 357);
            Controls.Add(chkEncrypted);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(cbFileFormat);
            Name = "ExportVault";
            Text = "ExportVault";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFileFormat;
        private Label label1;
        private Button btnConfirm;
        private CheckBox chkEncrypted;
    }
}