namespace FormWarden.Forms
{
    partial class Vault
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
            dgvIdentities = new DataGridView();
            label1 = new Label();
            btnNewIdentity = new Button();
            btnSignOut = new Button();
            CategoryCbx = new ComboBox();
            newCategoryBtn = new Button();
            deleteCategoryBtn = new Button();
            btnExport = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIdentities).BeginInit();
            SuspendLayout();
            // 
            // dgvIdentities
            // 
            dgvIdentities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdentities.Location = new Point(167, 72);
            dgvIdentities.Name = "dgvIdentities";
            dgvIdentities.RowTemplate.Height = 25;
            dgvIdentities.Size = new Size(795, 338);
            dgvIdentities.TabIndex = 0;
            dgvIdentities.CellContentClick += dgvIdentities_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 37);
            label1.TabIndex = 1;
            label1.Text = "All vaults";
            // 
            // btnNewIdentity
            // 
            btnNewIdentity.BackColor = SystemColors.Highlight;
            btnNewIdentity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewIdentity.ForeColor = Color.Transparent;
            btnNewIdentity.Location = new Point(851, 22);
            btnNewIdentity.Name = "btnNewIdentity";
            btnNewIdentity.Size = new Size(111, 37);
            btnNewIdentity.TabIndex = 2;
            btnNewIdentity.Text = "+ New item";
            btnNewIdentity.UseVisualStyleBackColor = false;
            btnNewIdentity.Click += btnNewIdentity_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(12, 36);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(75, 23);
            btnSignOut.TabIndex = 3;
            btnSignOut.Text = "Sign out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // CategoryCbx
            // 
            CategoryCbx.FormattingEnabled = true;
            CategoryCbx.Location = new Point(12, 72);
            CategoryCbx.Name = "CategoryCbx";
            CategoryCbx.Size = new Size(121, 23);
            CategoryCbx.TabIndex = 4;
            CategoryCbx.SelectedIndexChanged += CategoryCbx_SelectedIndexChanged;
            // 
            // newCategoryBtn
            // 
            newCategoryBtn.BackColor = SystemColors.Highlight;
            newCategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newCategoryBtn.ForeColor = Color.Transparent;
            newCategoryBtn.Location = new Point(715, 22);
            newCategoryBtn.Name = "newCategoryBtn";
            newCategoryBtn.Size = new Size(130, 37);
            newCategoryBtn.TabIndex = 5;
            newCategoryBtn.Text = "+ New category";
            newCategoryBtn.UseVisualStyleBackColor = false;
            newCategoryBtn.Click += newCategoryBtn_Click;
            // 
            // deleteCategoryBtn
            // 
            deleteCategoryBtn.BackColor = SystemColors.Highlight;
            deleteCategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCategoryBtn.ForeColor = Color.Transparent;
            deleteCategoryBtn.Location = new Point(572, 22);
            deleteCategoryBtn.Name = "deleteCategoryBtn";
            deleteCategoryBtn.Size = new Size(137, 37);
            deleteCategoryBtn.TabIndex = 6;
            deleteCategoryBtn.Text = "- Delete category";
            deleteCategoryBtn.UseVisualStyleBackColor = false;
            deleteCategoryBtn.Click += deleteCategoryBtn_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 331);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(121, 23);
            btnExport.TabIndex = 7;
            btnExport.Text = "Export vault";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(12, 290);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(121, 23);
            btnImport.TabIndex = 8;
            btnImport.Text = "Import file";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // Vault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(deleteCategoryBtn);
            Controls.Add(newCategoryBtn);
            Controls.Add(CategoryCbx);
            Controls.Add(btnSignOut);
            Controls.Add(btnNewIdentity);
            Controls.Add(label1);
            Controls.Add(dgvIdentities);
            Name = "Vault";
            Text = "Vault";
            FormClosing += Vault_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvIdentities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIdentities;
        private Label label1;
        private Button btnNewIdentity;
        private Button btnSignOut;
        private ComboBox CategoryCbx;
        private Button newCategoryBtn;
        private Button deleteCategoryBtn;
        private Button btnExport;
        private Button btnImport;
    }
}