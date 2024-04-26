namespace Text_Message_CMPG_315_Poject.Forms
{
    partial class frmRegister
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
            this.lblRegisterHeading = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnNavigateToLogin = new System.Windows.Forms.Button();
            this.tbxConfirmPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRgisterConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegisterHeading
            // 
            this.lblRegisterHeading.AutoSize = true;
            this.lblRegisterHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHeading.Location = new System.Drawing.Point(131, 36);
            this.lblRegisterHeading.Name = "lblRegisterHeading";
            this.lblRegisterHeading.Size = new System.Drawing.Size(142, 37);
            this.lblRegisterHeading.TabIndex = 9;
            this.lblRegisterHeading.Text = "Register";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(58, 216);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(301, 31);
            this.tbxPassword.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(58, 138);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(301, 31);
            this.tbxEmail.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(74, 354);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(255, 65);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnNavigateToLogin
            // 
            this.btnNavigateToLogin.Location = new System.Drawing.Point(74, 449);
            this.btnNavigateToLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnNavigateToLogin.Name = "btnNavigateToLogin";
            this.btnNavigateToLogin.Size = new System.Drawing.Size(255, 65);
            this.btnNavigateToLogin.TabIndex = 5;
            this.btnNavigateToLogin.Text = "Login to an account";
            this.btnNavigateToLogin.UseVisualStyleBackColor = true;
            this.btnNavigateToLogin.Click += new System.EventHandler(this.btnNavigateToLogin_Click);
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(60, 287);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(301, 31);
            this.tbxConfirmPassword.TabIndex = 10;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(55, 110);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(65, 25);
            this.lblRegisterEmail.TabIndex = 11;
            this.lblRegisterEmail.Text = "Email";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(55, 188);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(106, 25);
            this.lblRegisterPassword.TabIndex = 12;
            this.lblRegisterPassword.Text = "Password";
            // 
            // lblRgisterConfirmPassword
            // 
            this.lblRgisterConfirmPassword.AutoSize = true;
            this.lblRgisterConfirmPassword.Location = new System.Drawing.Point(55, 263);
            this.lblRgisterConfirmPassword.Name = "lblRgisterConfirmPassword";
            this.lblRgisterConfirmPassword.Size = new System.Drawing.Size(186, 25);
            this.lblRgisterConfirmPassword.TabIndex = 13;
            this.lblRgisterConfirmPassword.Text = "Confirm Password";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 551);
            this.Controls.Add(this.lblRgisterConfirmPassword);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterEmail);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblRegisterHeading);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnNavigateToLogin);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterHeading;
        private System.Windows.Forms.MaskedTextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnNavigateToLogin;
        private System.Windows.Forms.MaskedTextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRgisterConfirmPassword;
    }
}