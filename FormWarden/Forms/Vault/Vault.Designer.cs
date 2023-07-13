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
            this.dgvIdentities = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewIdentity = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btGenerator = new System.Windows.Forms.Button();
            this.CategoryCbx = new System.Windows.Forms.ComboBox();
            this.newCategoryBtn = new System.Windows.Forms.Button();
            this.deleteCategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIdentities
            // 
            this.dgvIdentities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdentities.Location = new System.Drawing.Point(167, 72);
            this.dgvIdentities.Name = "dgvIdentities";
            this.dgvIdentities.RowTemplate.Height = 25;
            this.dgvIdentities.Size = new System.Drawing.Size(726, 338);
            this.dgvIdentities.TabIndex = 0;
            this.dgvIdentities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdentities_CellContentClick);
            this.dgvIdentities.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdentities_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "All vaults";
            // 
            // btnNewIdentity
            // 
            this.btnNewIdentity.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewIdentity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewIdentity.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewIdentity.Location = new System.Drawing.Point(782, 22);
            this.btnNewIdentity.Name = "btnNewIdentity";
            this.btnNewIdentity.Size = new System.Drawing.Size(111, 37);
            this.btnNewIdentity.TabIndex = 2;
            this.btnNewIdentity.Text = "+ New item";
            this.btnNewIdentity.UseVisualStyleBackColor = false;
            this.btnNewIdentity.Click += new System.EventHandler(this.btnNewIdentity_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(12, 72);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(101, 39);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btGenerator
            // 
            this.btGenerator.Location = new System.Drawing.Point(12, 139);
            this.btGenerator.Name = "btGenerator";
            this.btGenerator.Size = new System.Drawing.Size(101, 37);
            this.btGenerator.TabIndex = 4;
            this.btGenerator.Text = "Generator";
            this.btGenerator.UseVisualStyleBackColor = true;
            this.btGenerator.Click += new System.EventHandler(this.btGenerator_Click);
            // 
            // CategoryCbx
            // 
            this.CategoryCbx.FormattingEnabled = true;
            this.CategoryCbx.Location = new System.Drawing.Point(12, 196);
            this.CategoryCbx.Name = "CategoryCbx";
            this.CategoryCbx.Size = new System.Drawing.Size(121, 23);
            this.CategoryCbx.TabIndex = 4;
            this.CategoryCbx.SelectedIndexChanged += new System.EventHandler(this.CategoryCbx_SelectedIndexChanged);
            // 
            // newCategoryBtn
            // 
            this.newCategoryBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.newCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCategoryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.newCategoryBtn.Location = new System.Drawing.Point(646, 22);
            this.newCategoryBtn.Name = "newCategoryBtn";
            this.newCategoryBtn.Size = new System.Drawing.Size(130, 37);
            this.newCategoryBtn.TabIndex = 5;
            this.newCategoryBtn.Text = "+ New category";
            this.newCategoryBtn.UseVisualStyleBackColor = false;
            this.newCategoryBtn.Click += new System.EventHandler(this.newCategoryBtn_Click);
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteCategoryBtn.Location = new System.Drawing.Point(503, 22);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(137, 37);
            this.deleteCategoryBtn.TabIndex = 6;
            this.deleteCategoryBtn.Text = "- Delete category";
            this.deleteCategoryBtn.UseVisualStyleBackColor = false;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btGenerator);
            this.Controls.Add(this.deleteCategoryBtn);
            this.Controls.Add(this.newCategoryBtn);
            this.Controls.Add(this.CategoryCbx);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnNewIdentity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIdentities);
            this.Name = "Vault";
            this.Text = "Vault";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvIdentities;
        private Label label1;
        private Button btnNewIdentity;
        private Button btnSignOut;
        private Button btGenerator;
        private ComboBox CategoryCbx;
        private Button newCategoryBtn;
        private Button deleteCategoryBtn;
    }
}