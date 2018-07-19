namespace WindowsFormsApp1
{
    partial class HalamanAwal
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
            this.btnLoginHalamanAwal = new System.Windows.Forms.Button();
            this.btnCariHalamanAwal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginHalamanAwal
            // 
            this.btnLoginHalamanAwal.Location = new System.Drawing.Point(86, 261);
            this.btnLoginHalamanAwal.Name = "btnLoginHalamanAwal";
            this.btnLoginHalamanAwal.Size = new System.Drawing.Size(75, 23);
            this.btnLoginHalamanAwal.TabIndex = 0;
            this.btnLoginHalamanAwal.Text = "LOGIN";
            this.btnLoginHalamanAwal.UseVisualStyleBackColor = true;
            this.btnLoginHalamanAwal.Click += new System.EventHandler(this.btnLoginHalamanAwal_Click);
            // 
            // btnCariHalamanAwal
            // 
            this.btnCariHalamanAwal.Location = new System.Drawing.Point(301, 261);
            this.btnCariHalamanAwal.Name = "btnCariHalamanAwal";
            this.btnCariHalamanAwal.Size = new System.Drawing.Size(75, 23);
            this.btnCariHalamanAwal.TabIndex = 1;
            this.btnCariHalamanAwal.Text = "SEARCH";
            this.btnCariHalamanAwal.UseVisualStyleBackColor = true;
            this.btnCariHalamanAwal.Click += new System.EventHandler(this.btnCariHalamanAwal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "PERPUS ONLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._18;
            this.pictureBox1.Location = new System.Drawing.Point(92, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HalamanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariHalamanAwal);
            this.Controls.Add(this.btnLoginHalamanAwal);
            this.Name = "HalamanAwal";
            this.Text = "HalamanAwal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginHalamanAwal;
        private System.Windows.Forms.Button btnCariHalamanAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}