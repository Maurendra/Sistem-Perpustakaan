namespace WindowsFormsApp1
{
    partial class MemberForm
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
            this.tbFullnameMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddressMember = new System.Windows.Forms.TextBox();
            this.tbPhoneMember = new System.Windows.Forms.TextBox();
            this.tbKodeMember = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullname";
            // 
            // tbFullnameMember
            // 
            this.tbFullnameMember.Location = new System.Drawing.Point(96, 12);
            this.tbFullnameMember.Name = "tbFullnameMember";
            this.tbFullnameMember.Size = new System.Drawing.Size(176, 20);
            this.tbFullnameMember.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "KTP/S/M";
            // 
            // tbAddressMember
            // 
            this.tbAddressMember.Location = new System.Drawing.Point(96, 38);
            this.tbAddressMember.Name = "tbAddressMember";
            this.tbAddressMember.Size = new System.Drawing.Size(176, 20);
            this.tbAddressMember.TabIndex = 5;
            // 
            // tbPhoneMember
            // 
            this.tbPhoneMember.Location = new System.Drawing.Point(96, 64);
            this.tbPhoneMember.Name = "tbPhoneMember";
            this.tbPhoneMember.Size = new System.Drawing.Size(176, 20);
            this.tbPhoneMember.TabIndex = 6;
            // 
            // tbKodeMember
            // 
            this.tbKodeMember.Location = new System.Drawing.Point(96, 90);
            this.tbKodeMember.Name = "tbKodeMember";
            this.tbKodeMember.Size = new System.Drawing.Size(176, 20);
            this.tbKodeMember.TabIndex = 7;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(116, 116);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.tbKodeMember);
            this.Controls.Add(this.tbPhoneMember);
            this.Controls.Add(this.tbAddressMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFullnameMember);
            this.Controls.Add(this.label1);
            this.Name = "MemberForm";
            this.Text = "MemberForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFullnameMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddressMember;
        private System.Windows.Forms.TextBox tbPhoneMember;
        private System.Windows.Forms.TextBox tbKodeMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnCancel;
    }
}