﻿namespace Text_Message_CMPG_315_Poject
{
    partial class frmLogin
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
            this.btnNavigateToRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavigateToRegister
            // 
            this.btnNavigateToRegister.Location = new System.Drawing.Point(34, 189);
            this.btnNavigateToRegister.Name = "btnNavigateToRegister";
            this.btnNavigateToRegister.Size = new System.Drawing.Size(128, 34);
            this.btnNavigateToRegister.TabIndex = 0;
            this.btnNavigateToRegister.Text = "Register an account";
            this.btnNavigateToRegister.UseVisualStyleBackColor = true;
            this.btnNavigateToRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(34, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 34);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(22, 68);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(152, 20);
            this.tbxEmail.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(22, 101);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(152, 20);
            this.tbxPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(20, 54);
            this.lblRegisterEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(32, 13);
            this.lblRegisterEmail.TabIndex = 12;
            this.lblRegisterEmail.Text = "Email";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(20, 87);
            this.lblRegisterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRegisterPassword.TabIndex = 13;
            this.lblRegisterPassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNavigateToRegister);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNavigateToRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.MaskedTextBox tbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Button button1;
    }
}

