namespace FormWarden
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
            ((System.ComponentModel.ISupportInitialize)dgvIdentities).BeginInit();
            SuspendLayout();
            // 
            // dgvIdentities
            // 
            dgvIdentities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdentities.Location = new Point(148, 68);
            dgvIdentities.Name = "dgvIdentities";
            dgvIdentities.RowTemplate.Height = 25;
            dgvIdentities.Size = new Size(613, 338);
            dgvIdentities.TabIndex = 0;
            dgvIdentities.CellContentClick += dgvIdentities_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 18);
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
            btnNewIdentity.Location = new Point(650, 18);
            btnNewIdentity.Name = "btnNewIdentity";
            btnNewIdentity.Size = new Size(111, 37);
            btnNewIdentity.TabIndex = 2;
            btnNewIdentity.Text = "+ New item";
            btnNewIdentity.UseVisualStyleBackColor = false;
            btnNewIdentity.Click += btnNewIdentity_Click;
            // 
            // Vault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewIdentity);
            Controls.Add(label1);
            Controls.Add(dgvIdentities);
            Name = "Vault";
            Text = "Vault";
            ((System.ComponentModel.ISupportInitialize)dgvIdentities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIdentities;
        private Label label1;
        private Button btnNewIdentity;
    }
}