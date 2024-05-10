
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.lblChatterUsername = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.chatterProfile = new System.Windows.Forms.PictureBox();
            this.txtbxSendMessage = new ChatApp_CMPG315.CTextBox();
            this.btnSendMessage = new ChatApp_CMPG315.CButton();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatterProfile)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMessages
            // 
            this.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessages.Controls.Add(this.lblChatterUsername);
            this.pnlMessages.Controls.Add(this.lstMessages);
            this.pnlMessages.Controls.Add(this.chatterProfile);
            this.pnlMessages.Controls.Add(this.txtbxSendMessage);
            this.pnlMessages.Controls.Add(this.btnSendMessage);
            this.pnlMessages.Location = new System.Drawing.Point(412, -5);
            this.pnlMessages.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(500, 472);
            this.pnlMessages.TabIndex = 6;
            // 
            // lblChatterUsername
            // 
            this.lblChatterUsername.AutoSize = true;
            this.lblChatterUsername.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatterUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChatterUsername.Location = new System.Drawing.Point(70, 22);
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
            this.lstMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(0, 80);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(2);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(488, 325);
            this.lstMessages.TabIndex = 6;
            this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.lstMessages_SelectedIndexChanged);
            // 
            // chatterProfile
            // 
            this.chatterProfile.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.Photo_on_2024_03_01_at_15_01;
            this.chatterProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatterProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("chatterProfile.InitialImage")));
            this.chatterProfile.Location = new System.Drawing.Point(9, 10);
            this.chatterProfile.Margin = new System.Windows.Forms.Padding(2);
            this.chatterProfile.Name = "chatterProfile";
            this.chatterProfile.Size = new System.Drawing.Size(50, 55);
            this.chatterProfile.TabIndex = 2;
            this.chatterProfile.TabStop = false;
            // 
            // txtbxSendMessage
            // 
            this.txtbxSendMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxSendMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxSendMessage.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtbxSendMessage.BorderSize = 2;
            this.txtbxSendMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSendMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbxSendMessage.Location = new System.Drawing.Point(3, 422);
            this.txtbxSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSendMessage.Multiline = false;
            this.txtbxSendMessage.Name = "txtbxSendMessage";
            this.txtbxSendMessage.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbxSendMessage.PasswordChar = false;
            this.txtbxSendMessage.Size = new System.Drawing.Size(422, 31);
            this.txtbxSendMessage.TabIndex = 5;
            this.txtbxSendMessage.Texts = "Message @Username";
            this.txtbxSendMessage.UnderlinedStyle = false;
            this.txtbxSendMessage._TextChanged += new System.EventHandler(this.cTextBox3__TextChanged);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendMessage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendMessage.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSendMessage.BorderRadius = 30;
            this.btnSendMessage.BorderSize = 2;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(426, 421);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(62, 32);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Slap 👏";
            this.btnSendMessage.TextColor = System.Drawing.Color.White;
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.cButton3_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsers.Controls.Add(this.lstUsers);
            this.pnlUsers.Controls.Add(this.pictureBox1);
            this.pnlUsers.Controls.Add(this.label1);
            this.pnlUsers.Location = new System.Drawing.Point(85, -5);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(328, 472);
            this.pnlUsers.TabIndex = 7;
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
            this.lstUsers.Location = new System.Drawing.Point(0, 56);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(327, 374);
            this.lstUsers.TabIndex = 7;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.AddUser1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfile.Controls.Add(this.btnback);
            this.pnlProfile.Controls.Add(this.userProfile);
            this.pnlProfile.Location = new System.Drawing.Point(-3, -5);
            this.pnlProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(89, 472);
            this.pnlProfile.TabIndex = 8;
            this.pnlProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.backbutton1;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.ErrorImage = null;
            this.btnback.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnback.InitialImage")));
            this.btnback.Location = new System.Drawing.Point(22, 10);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 54);
            this.btnback.TabIndex = 8;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // userProfile
            // 
            this.userProfile.BackgroundImage = global::ChatApp_CMPG315.Properties.Resources.Photo_on_2024_03_01_at_15_01;
            this.userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("userProfile.InitialImage")));
            this.userProfile.Location = new System.Drawing.Point(22, 396);
            this.userProfile.Margin = new System.Windows.Forms.Padding(2);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(50, 55);
            this.userProfile.TabIndex = 1;
            this.userProfile.TabStop = false;
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 457);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "TheSlap";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.ChatForm_Shown);
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatterProfile)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTextBox txtbxSendMessage;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userProfile;
        private System.Windows.Forms.PictureBox chatterProfile;
        private CButton btnSendMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblChatterUsername;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.PictureBox btnback;
    }
}

