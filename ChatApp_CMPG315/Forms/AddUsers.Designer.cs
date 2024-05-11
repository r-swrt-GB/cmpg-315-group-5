
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new ChatApp_CMPG315.CTextBox();
            this.clbxUsers = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGroup = new ChatApp_CMPG315.CButton();
            this.txtGroupName = new ChatApp_CMPG315.CTextBox();
            this.cbxGroups = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlap = new ChatApp_CMPG315.CButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cButton4 = new ChatApp_CMPG315.CButton();
            this.clbxNewUsers = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.clbxUsers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCreateGroup);
            this.panel1.Controls.Add(this.txtGroupName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 339);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(16, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 22);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDescription.Location = new System.Drawing.Point(21, 173);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Size = new System.Drawing.Size(250, 37);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // clbxUsers
            // 
            this.clbxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clbxUsers.CheckOnClick = true;
            this.clbxUsers.FormattingEnabled = true;
            this.clbxUsers.Location = new System.Drawing.Point(295, 85);
            this.clbxUsers.Name = "clbxUsers";
            this.clbxUsers.Size = new System.Drawing.Size(193, 235);
            this.clbxUsers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(170, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
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
            this.btnCreateGroup.Location = new System.Drawing.Point(20, 278);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(251, 36);
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
            this.txtGroupName.Location = new System.Drawing.Point(21, 85);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupName.Multiline = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Padding = new System.Windows.Forms.Padding(7);
            this.txtGroupName.PasswordChar = false;
            this.txtGroupName.Size = new System.Drawing.Size(249, 37);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.Texts = "";
            this.txtGroupName.UnderlinedStyle = false;
            // 
            // cbxGroups
            // 
            this.cbxGroups.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxGroups.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxGroups.FormattingEnabled = true;
            this.cbxGroups.Location = new System.Drawing.Point(21, 96);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.Size = new System.Drawing.Size(250, 30);
            this.cbxGroups.TabIndex = 4;
            this.cbxGroups.Text = "Users";
            this.cbxGroups.SelectedIndexChanged += new System.EventHandler(this.cbxUsers_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSlap);
            this.panel2.Controls.Add(this.cbxGroups);
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 317);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(89, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
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
            this.btnSlap.Location = new System.Drawing.Point(20, 258);
            this.btnSlap.Name = "btnSlap";
            this.btnSlap.Size = new System.Drawing.Size(250, 36);
            this.btnSlap.TabIndex = 1;
            this.btnSlap.Text = "👏 Slap";
            this.btnSlap.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSlap.UseVisualStyleBackColor = false;
            this.btnSlap.Click += new System.EventHandler(this.btnSlap_Click);
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
            this.cButton4.Location = new System.Drawing.Point(332, 605);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(131, 36);
            this.cButton4.TabIndex = 2;
            this.cButton4.Text = "Back";
            this.cButton4.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton4.UseVisualStyleBackColor = false;
            this.cButton4.Click += new System.EventHandler(this.cButton4_Click);
            // 
            // clbxNewUsers
            // 
            this.clbxNewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clbxNewUsers.CheckOnClick = true;
            this.clbxNewUsers.FormattingEnabled = true;
            this.clbxNewUsers.Location = new System.Drawing.Point(302, 367);
            this.clbxNewUsers.Name = "clbxNewUsers";
            this.clbxNewUsers.Size = new System.Drawing.Size(193, 229);
            this.clbxNewUsers.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(298, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select users to add";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddUser.Location = new System.Drawing.Point(302, 342);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(187, 22);
            this.lblAddUser.TabIndex = 10;
            this.lblAddUser.Text = "Add New User to group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a group to add new members";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(488, 645);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.clbxNewUsers);
            this.Controls.Add(this.cButton4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(508, 688);
            this.Name = "AddUsers";
            this.Text = "AddUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CButton btnCreateGroup;
        private CTextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGroups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private CButton btnSlap;
        private CButton cButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblDescription;
        private CTextBox txtDescription;
        private System.Windows.Forms.CheckedListBox clbxUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbxNewUsers;
        private System.Windows.Forms.Label lblAddUser;
    }
}