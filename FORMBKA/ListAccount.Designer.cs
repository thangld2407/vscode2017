namespace FORMBKA
{
    partial class ListAccount
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.txtNewAccount = new System.Windows.Forms.TextBox();
            this.txtAddNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 253);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(450, 330);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAccount.Location = new System.Drawing.Point(138, 177);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(173, 37);
            this.btnAddNewAccount.TabIndex = 1;
            this.btnAddNewAccount.Text = "Thêm tài khoản";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // txtNewAccount
            // 
            this.txtNewAccount.Location = new System.Drawing.Point(116, 39);
            this.txtNewAccount.Name = "txtNewAccount";
            this.txtNewAccount.Size = new System.Drawing.Size(221, 20);
            this.txtNewAccount.TabIndex = 2;
            // 
            // txtAddNewPassword
            // 
            this.txtAddNewPassword.Location = new System.Drawing.Point(116, 88);
            this.txtAddNewPassword.Name = "txtAddNewPassword";
            this.txtAddNewPassword.Size = new System.Drawing.Size(221, 20);
            this.txtAddNewPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vai trò";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(116, 136);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(221, 20);
            this.txtRole.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "0: admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "1: operator";
            // 
            // ListAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddNewPassword);
            this.Controls.Add(this.txtNewAccount);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.dgvAccount);
            this.Name = "ListAccount";
            this.Text = "ListAccount";
            this.Load += new System.EventHandler(this.ListAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.TextBox txtNewAccount;
        private System.Windows.Forms.TextBox txtAddNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}