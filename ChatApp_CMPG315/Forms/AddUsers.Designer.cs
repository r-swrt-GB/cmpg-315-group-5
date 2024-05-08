
namespace ChatApp_CMPG315
{
    partial class AddUsers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richSelectedUsers = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGroup = new ChatApp_CMPG315.CButton();
            this.txtGroupName = new ChatApp_CMPG315.CTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlap = new ChatApp_CMPG315.CButton();
            this.txtEmail = new ChatApp_CMPG315.CTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cButton4 = new ChatApp_CMPG315.CButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.richSelectedUsers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCreateGroup);
            this.panel1.Controls.Add(this.txtGroupName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 651);
            this.panel1.TabIndex = 0;
            // 
            // richSelectedUsers
            // 
            this.richSelectedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richSelectedUsers.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.richSelectedUsers.Location = new System.Drawing.Point(592, 163);
            this.richSelectedUsers.Margin = new System.Windows.Forms.Padding(6);
            this.richSelectedUsers.Name = "richSelectedUsers";
            this.richSelectedUsers.Size = new System.Drawing.Size(388, 481);
            this.richSelectedUsers.TabIndex = 7;
            this.richSelectedUsers.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(340, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create Group";
            // 
            // cbxUsers
            // 
            this.cbxUsers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(42, 265);
            this.cbxUsers.Margin = new System.Windows.Forms.Padding(6);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(496, 48);
            this.cbxUsers.TabIndex = 4;
            this.cbxUsers.Text = "Users";
            this.cbxUsers.SelectedIndexChanged += new System.EventHandler(this.cbxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnCreateGroup.Location = new System.Drawing.Point(40, 535);
            this.btnCreateGroup.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(502, 69);
            this.btnCreateGroup.TabIndex = 1;
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
            this.txtGroupName.Location = new System.Drawing.Point(42, 163);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(8);
            this.txtGroupName.Multiline = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtGroupName.PasswordChar = false;
            this.txtGroupName.Size = new System.Drawing.Size(498, 67);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.Texts = "";
            this.txtGroupName.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSlap);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 610);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(178, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add User";
            // 
            // btnSlap
            // 
            this.btnSlap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSlap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSlap.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSlap.BorderRadius = 30;
            this.btnSlap.BorderSize = 1;
            this.btnSlap.FlatAppearance.BorderSize = 0;
            this.btnSlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlap.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSlap.Location = new System.Drawing.Point(40, 496);
            this.btnSlap.Margin = new System.Windows.Forms.Padding(6);
            this.btnSlap.Name = "btnSlap";
            this.btnSlap.Size = new System.Drawing.Size(500, 69);
            this.btnSlap.TabIndex = 1;
            this.btnSlap.Text = "👏 Slap";
            this.btnSlap.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSlap.UseVisualStyleBackColor = false;
            this.btnSlap.Click += new System.EventHandler(this.btnSlap_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEmail.Location = new System.Drawing.Point(40, 142);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(500, 67);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cButton4
            // 
            this.cButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton4.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.cButton4.BorderRadius = 30;
            this.cButton4.BorderSize = 1;
            this.cButton4.FlatAppearance.BorderSize = 0;
            this.cButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton4.Location = new System.Drawing.Point(664, 1163);
            this.cButton4.Margin = new System.Windows.Forms.Padding(6);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(262, 69);
            this.cButton4.TabIndex = 2;
            this.cButton4.Text = "Back";
            this.cButton4.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton4.UseVisualStyleBackColor = false;
            this.cButton4.Click += new System.EventHandler(this.cButton4_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(966, 1209);
            this.Controls.Add(this.cButton4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(996, 1284);
            this.Name = "AddUsers";
            this.Text = "AddUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CButton btnCreateGroup;
        private CTextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private CButton btnSlap;
        private CTextBox txtEmail;
        private CButton cButton4;
        private System.Windows.Forms.RichTextBox richSelectedUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
    }
}