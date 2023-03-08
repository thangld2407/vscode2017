namespace FORMBKA
{
    partial class ChangePw
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
            this.txtConfirmPw = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnCloseModalPw = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirmPw
            // 
            this.txtConfirmPw.Location = new System.Drawing.Point(147, 72);
            this.txtConfirmPw.Name = "txtConfirmPw";
            this.txtConfirmPw.PasswordChar = '*';
            this.txtConfirmPw.Size = new System.Drawing.Size(174, 20);
            this.txtConfirmPw.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(147, 28);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(174, 20);
            this.txtNewPassword.TabIndex = 10;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // btnCloseModalPw
            // 
            this.btnCloseModalPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModalPw.Location = new System.Drawing.Point(246, 123);
            this.btnCloseModalPw.Name = "btnCloseModalPw";
            this.btnCloseModalPw.Size = new System.Drawing.Size(75, 32);
            this.btnCloseModalPw.TabIndex = 13;
            this.btnCloseModalPw.Text = "Thoát";
            this.btnCloseModalPw.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(98, 123);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(126, 32);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(30, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 16);
            this.label.TabIndex = 8;
            this.label.Text = "Confirm";
            // 
            // labelold
            // 
            this.labelold.AutoSize = true;
            this.labelold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelold.Location = new System.Drawing.Point(30, 28);
            this.labelold.Name = "labelold";
            this.labelold.Size = new System.Drawing.Size(102, 16);
            this.labelold.TabIndex = 7;
            this.labelold.Text = "New Pasword";
            // 
            // ChangePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 182);
            this.Controls.Add(this.btnCloseModalPw);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirmPw);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelold);
            this.Name = "ChangePw";
            this.Text = "ChangePw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseModalPw;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelold;
        private System.Windows.Forms.TextBox txtConfirmPw;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}