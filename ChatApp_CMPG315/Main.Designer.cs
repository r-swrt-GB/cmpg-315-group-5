
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChatterUsername = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbxSendMessage = new ChatApp_CMPG315.CTextBox();
            this.btnSendMessage = new ChatApp_CMPG315.CButton();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chatterProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatterProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblChatterUsername);
            this.panel1.Controls.Add(this.lstMessages);
            this.panel1.Controls.Add(this.chatterProfile);
            this.panel1.Controls.Add(this.txtbxSendMessage);
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Location = new System.Drawing.Point(823, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 905);
            this.panel1.TabIndex = 6;
            // 
            // lblChatterUsername
            // 
            this.lblChatterUsername.AutoSize = true;
            this.lblChatterUsername.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblChatterUsername.Location = new System.Drawing.Point(139, 43);
            this.lblChatterUsername.Name = "lblChatterUsername";
            this.lblChatterUsername.Size = new System.Drawing.Size(239, 49);
            this.lblChatterUsername.TabIndex = 7;
            this.lblChatterUsername.Text = "@Username";
            // 
            // lstMessages
            // 
            this.lstMessages.BackColor = System.Drawing.SystemColors.MenuText;
            this.lstMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 25;
            this.lstMessages.Location = new System.Drawing.Point(-1, 153);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(977, 625);
            this.lstMessages.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(170, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 905);
            this.panel2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 40;
            this.listBox1.Items.AddRange(new object[] {
            "@user1",
            "@user2",
            "@user3"});
            this.listBox1.Location = new System.Drawing.Point(-1, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(654, 760);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.userProfile);
            this.panel3.Location = new System.Drawing.Point(-6, -9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 905);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtbxSendMessage
            // 
            this.txtbxSendMessage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbxSendMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxSendMessage.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtbxSendMessage.BorderSize = 2;
            this.txtbxSendMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSendMessage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbxSendMessage.Location = new System.Drawing.Point(6, 812);
            this.txtbxSendMessage.Margin = new System.Windows.Forms.Padding(6);
            this.txtbxSendMessage.Multiline = false;
            this.txtbxSendMessage.Name = "txtbxSendMessage";
            this.txtbxSendMessage.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txtbxSendMessage.PasswordChar = false;
            this.txtbxSendMessage.Size = new System.Drawing.Size(863, 52);
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
            this.btnSendMessage.Location = new System.Drawing.Point(880, 809);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(86, 61);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Slap";
            this.btnSendMessage.TextColor = System.Drawing.Color.White;
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.cButton3_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnback.InitialImage")));
            this.btnback.Location = new System.Drawing.Point(43, 20);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 104);
            this.btnback.TabIndex = 8;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // userProfile
            // 
            this.userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("userProfile.InitialImage")));
            this.userProfile.Location = new System.Drawing.Point(43, 761);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(100, 105);
            this.userProfile.TabIndex = 1;
            this.userProfile.TabStop = false;
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(549, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 105);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chatterProfile
            // 
            this.chatterProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatterProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("chatterProfile.InitialImage")));
            this.chatterProfile.Location = new System.Drawing.Point(18, 19);
            this.chatterProfile.Name = "chatterProfile";
            this.chatterProfile.Size = new System.Drawing.Size(100, 105);
            this.chatterProfile.TabIndex = 2;
            this.chatterProfile.TabStop = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1800, 879);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "TheSlap";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatterProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTextBox txtbxSendMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userProfile;
        private System.Windows.Forms.PictureBox chatterProfile;
        private CButton btnSendMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblChatterUsername;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox btnback;
    }
}

