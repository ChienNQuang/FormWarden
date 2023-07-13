namespace FormWarden.Forms
{
    partial class ImportFile
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
            openFileDialog = new OpenFileDialog();
            btnChooseFile = new Button();
            txtFileName = new TextBox();
            btnImport = new Button();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(43, 44);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(93, 23);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(43, 86);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(297, 23);
            txtFileName.TabIndex = 1;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.ActiveCaption;
            btnImport.Location = new Point(43, 136);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 2;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // ImportFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 320);
            Controls.Add(btnImport);
            Controls.Add(txtFileName);
            Controls.Add(btnChooseFile);
            Name = "ImportFile";
            Text = "ImportFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button btnChooseFile;
        private TextBox txtFileName;
        private Button btnImport;
    }
}