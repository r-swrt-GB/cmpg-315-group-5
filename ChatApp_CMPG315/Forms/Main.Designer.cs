
namespace ChatApp_CMPG315
{
    partial class ChatForm
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
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblChatterUsername = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.txtbxSendMessage = new ChatApp_CMPG315.CTextBox();
            this.btnSendGroupMessage = new ChatApp_CMPG315.CButton();
            this.btnSendPrivateMessage = new ChatApp_CMPG315.CButton();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cButton1 = new ChatApp_CMPG315.CButton();
            this.btnCreateGroup = new ChatApp_CMPG315.CButton();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMessages
            // 
            this.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessages.Controls.Add(this.pictureBox1);
            this.pnlMessages.Controls.Add(this.panel1);
            this.pnlMessages.Controls.Add(this.panel7);
            this.pnlMessages.Controls.Add(this.lblEmail);
            this.pnlMessages.Controls.Add(this.panel6);
            this.pnlMessages.Controls.Add(this.lblChatterUsername);
            this.pnlMessages.Controls.Add(this.lstMessages);
            this.pnlMessages.Controls.Add(this.txtbxSendMessage);
            this.pnlMessages.Controls.Add(this.btnSendGroupMessage);
            this.pnlMessages.Controls.Add(this.btnSendPrivateMessage);
            this.pnlMessages.Location = new System.Drawing.Point(334, 11);
            this.pnlMessages.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(500, 472);
            this.pnlMessages.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.icons8_close_window_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(478, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(489, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 453);
            this.panel1.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(6, 383);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(497, 7);
            this.panel7.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(12, 38);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 18);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "@Email";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(0, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(497, 7);
            this.panel6.TabIndex = 16;
            // 
            // lblChatterUsername
            // 
            this.lblChatterUsername.AutoSize = true;
            this.lblChatterUsername.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatterUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChatterUsername.Location = new System.Drawing.Point(12, 12);
            this.lblChatterUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChatterUsername.Name = "lblChatterUsername";
            this.lblChatterUsername.Size = new System.Drawing.Size(123, 26);
            this.lblChatterUsername.TabIndex = 7;
            this.lblChatterUsername.Text = "@Username";
            // 
            // lstMessages
            // 
            this.lstMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.HorizontalScrollbar = true;
            this.lstMessages.ItemHeight = 20;
            this.lstMessages.Location = new System.Drawing.Point(17, 80);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(2);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(467, 280);
            this.lstMessages.TabIndex = 6;
            // 
            // txtbxSendMessage
            // 
            this.txtbxSendMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxSendMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxSendMessage.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtbxSendMessage.BorderSize = 2;
            this.txtbxSendMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSendMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbxSendMessage.Location = new System.Drawing.Point(17, 413);
            this.txtbxSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSendMessage.Multiline = false;
            this.txtbxSendMessage.Name = "txtbxSendMessage";
            this.txtbxSendMessage.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbxSendMessage.PasswordChar = false;
            this.txtbxSendMessage.Size = new System.Drawing.Size(408, 31);
            this.txtbxSendMessage.TabIndex = 5;
            this.txtbxSendMessage.Texts = "Type your message here...";
            this.txtbxSendMessage.UnderlinedStyle = false;
            this.txtbxSendMessage.Click += new System.EventHandler(this.txtbxSendMessage_Click);
            // 
            // btnSendGroupMessage
            // 
            this.btnSendGroupMessage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendGroupMessage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendGroupMessage.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSendGroupMessage.BorderRadius = 30;
            this.btnSendGroupMessage.BorderSize = 2;
            this.btnSendGroupMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendGroupMessage.FlatAppearance.BorderSize = 0;
            this.btnSendGroupMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendGroupMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendGroupMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendGroupMessage.Location = new System.Drawing.Point(426, 412);
            this.btnSendGroupMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendGroupMessage.Name = "btnSendGroupMessage";
            this.btnSendGroupMessage.Size = new System.Drawing.Size(62, 32);
            this.btnSendGroupMessage.TabIndex = 18;
            this.btnSendGroupMessage.Text = "Slap 👏";
            this.btnSendGroupMessage.TextColor = System.Drawing.Color.White;
            this.btnSendGroupMessage.UseVisualStyleBackColor = false;
            this.btnSendGroupMessage.Click += new System.EventHandler(this.btnSendGroupMessage_Click);
            // 
            // btnSendPrivateMessage
            // 
            this.btnSendPrivateMessage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendPrivateMessage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendPrivateMessage.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSendPrivateMessage.BorderRadius = 30;
            this.btnSendPrivateMessage.BorderSize = 2;
            this.btnSendPrivateMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendPrivateMessage.FlatAppearance.BorderSize = 0;
            this.btnSendPrivateMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPrivateMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPrivateMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendPrivateMessage.Location = new System.Drawing.Point(426, 412);
            this.btnSendPrivateMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendPrivateMessage.Name = "btnSendPrivateMessage";
            this.btnSendPrivateMessage.Size = new System.Drawing.Size(62, 32);
            this.btnSendPrivateMessage.TabIndex = 2;
            this.btnSendPrivateMessage.Text = "Slap 👏";
            this.btnSendPrivateMessage.TextColor = System.Drawing.Color.White;
            this.btnSendPrivateMessage.UseVisualStyleBackColor = false;
            this.btnSendPrivateMessage.Click += new System.EventHandler(this.cButton3_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsers.Controls.Add(this.panel5);
            this.pnlUsers.Controls.Add(this.lstUsers);
            this.pnlUsers.Controls.Add(this.label1);
            this.pnlUsers.Controls.Add(this.userProfile);
            this.pnlUsers.Location = new System.Drawing.Point(10, 18);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(328, 381);
            this.pnlUsers.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 7);
            this.panel5.TabIndex = 15;
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 22;
            this.lstUsers.Items.AddRange(new object[] {
            "@user1",
            "@user2",
            "@user3"});
            this.lstUsers.Location = new System.Drawing.Point(2, 66);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(317, 286);
            this.lstUsers.TabIndex = 7;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userProfile
            // 
            this.userProfile.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.def_copy_removebg_preview;
            this.userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userProfile.InitialImage = null;
            this.userProfile.Location = new System.Drawing.Point(251, -8);
            this.userProfile.Margin = new System.Windows.Forms.Padding(2);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(73, 70);
            this.userProfile.TabIndex = 1;
            this.userProfile.TabStop = false;
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(7, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 7);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(332, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 453);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(2, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 453);
            this.panel4.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(2, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(831, 10);
            this.panel8.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(3, 460);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(832, 10);
            this.panel9.TabIndex = 19;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.cButton1.BorderRadius = 30;
            this.cButton1.BorderSize = 1;
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.Location = new System.Drawing.Point(175, 421);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(151, 36);
            this.cButton1.TabIndex = 11;
            this.cButton1.Text = "New Contact";
            this.cButton1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateGroup.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreateGroup.BorderRadius = 30;
            this.btnCreateGroup.BorderSize = 1;
            this.btnCreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGroup.FlatAppearance.BorderSize = 0;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.Location = new System.Drawing.Point(18, 421);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(150, 36);
            this.btnCreateGroup.TabIndex = 10;
            this.btnCreateGroup.Text = "New Group";
            this.btnCreateGroup.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(842, 472);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.pnlUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheSlap";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.ChatForm_Shown);
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTextBox txtbxSendMessage;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userProfile;
        private CButton btnSendPrivateMessage;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblChatterUsername;
        private System.Windows.Forms.ListBox lstUsers;
        private CButton btnCreateGroup;
        private CButton cButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private CButton btnSendGroupMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}

