namespace ChatApp_CMPG315.Forms
{
    partial class AddGroup
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
            this.richSelectedUsers = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGroup = new ChatApp_CMPG315.CButton();
            this.txtGroupName = new ChatApp_CMPG315.CTextBox();
            this.SuspendLayout();
            // 
            // richSelectedUsers
            // 
            this.richSelectedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richSelectedUsers.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.richSelectedUsers.Location = new System.Drawing.Point(339, 235);
            this.richSelectedUsers.Name = "richSelectedUsers";
            this.richSelectedUsers.Size = new System.Drawing.Size(196, 252);
            this.richSelectedUsers.TabIndex = 13;
            this.richSelectedUsers.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(213, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Create Group";
            // 
            // cbxUsers
            // 
            this.cbxUsers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(64, 288);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(250, 30);
            this.cbxUsers.TabIndex = 11;
            this.cbxUsers.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Group Name";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreateGroup.BorderRadius = 30;
            this.btnCreateGroup.BorderSize = 1;
            this.btnCreateGroup.FlatAppearance.BorderSize = 0;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.Location = new System.Drawing.Point(63, 428);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(251, 36);
            this.btnCreateGroup.TabIndex = 9;
            this.btnCreateGroup.Text = "Create Group 👏";
            this.btnCreateGroup.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGroupName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGroupName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGroupName.BorderSize = 2;
            this.txtGroupName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGroupName.Location = new System.Drawing.Point(64, 235);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupName.Multiline = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Padding = new System.Windows.Forms.Padding(7);
            this.txtGroupName.PasswordChar = false;
            this.txtGroupName.Size = new System.Drawing.Size(249, 37);
            this.txtGroupName.TabIndex = 8;
            this.txtGroupName.Texts = "";
            this.txtGroupName.UnderlinedStyle = false;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 656);
            this.Controls.Add(this.richSelectedUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.txtGroupName);
            this.MaximumSize = new System.Drawing.Size(610, 695);
            this.MinimumSize = new System.Drawing.Size(610, 695);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richSelectedUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Label label1;
        private CButton btnCreateGroup;
        private CTextBox txtGroupName;
    }
}