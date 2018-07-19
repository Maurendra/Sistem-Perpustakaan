namespace WindowsFormsApp1
{
    partial class ManageItemsForm
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
            this.btnAddBuku = new System.Windows.Forms.Button();
            this.btnEditBuku = new System.Windows.Forms.Button();
            this.btnDetailBuku = new System.Windows.Forms.Button();
            this.btnDeleteBuku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListBuku = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBuku
            // 
            this.btnAddBuku.Location = new System.Drawing.Point(477, 17);
            this.btnAddBuku.Name = "btnAddBuku";
            this.btnAddBuku.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuku.TabIndex = 0;
            this.btnAddBuku.Text = "Add";
            this.btnAddBuku.UseVisualStyleBackColor = true;
            this.btnAddBuku.Click += new System.EventHandler(this.btnAddBuku_Click);
            // 
            // btnEditBuku
            // 
            this.btnEditBuku.Location = new System.Drawing.Point(477, 46);
            this.btnEditBuku.Name = "btnEditBuku";
            this.btnEditBuku.Size = new System.Drawing.Size(75, 23);
            this.btnEditBuku.TabIndex = 1;
            this.btnEditBuku.Text = "Edit";
            this.btnEditBuku.UseVisualStyleBackColor = true;
            this.btnEditBuku.Click += new System.EventHandler(this.btnEditBuku_Click);
            // 
            // btnDetailBuku
            // 
            this.btnDetailBuku.Location = new System.Drawing.Point(477, 75);
            this.btnDetailBuku.Name = "btnDetailBuku";
            this.btnDetailBuku.Size = new System.Drawing.Size(75, 23);
            this.btnDetailBuku.TabIndex = 2;
            this.btnDetailBuku.Text = "Detail";
            this.btnDetailBuku.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBuku
            // 
            this.btnDeleteBuku.Location = new System.Drawing.Point(477, 104);
            this.btnDeleteBuku.Name = "btnDeleteBuku";
            this.btnDeleteBuku.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBuku.TabIndex = 3;
            this.btnDeleteBuku.Text = "Delete";
            this.btnDeleteBuku.UseVisualStyleBackColor = true;
            this.btnDeleteBuku.Click += new System.EventHandler(this.btnDeleteBuku_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListBuku);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lists";
            // 
            // dgvListBuku
            // 
            this.dgvListBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBuku.Location = new System.Drawing.Point(7, 19);
            this.dgvListBuku.Name = "dgvListBuku";
            this.dgvListBuku.Size = new System.Drawing.Size(446, 242);
            this.dgvListBuku.TabIndex = 0;
            this.dgvListBuku.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBuku_CellEnter);
            // 
            // ManageItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteBuku);
            this.Controls.Add(this.btnDetailBuku);
            this.Controls.Add(this.btnEditBuku);
            this.Controls.Add(this.btnAddBuku);
            this.Name = "ManageItemsForm";
            this.Text = "ManageItems";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBuku;
        private System.Windows.Forms.Button btnEditBuku;
        private System.Windows.Forms.Button btnDetailBuku;
        private System.Windows.Forms.Button btnDeleteBuku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListBuku;
    }
}