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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContacs = new System.Windows.Forms.CheckedListBox();
            this.rbxNoContacts = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbxGroupMembers = new System.Windows.Forms.ListBox();
            this.btnCreateGroup = new ChatApp_CMPG315.CButton();
            this.txtGroupName = new ChatApp_CMPG315.CTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(154, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(189, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "NEW GROUP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatApp_CMPG315.Properties.Resources.Speech;
            this.pictureBox2.Location = new System.Drawing.Point(210, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contacts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(314, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Group members";
            // 
            // cbxContacs
            // 
            this.cbxContacs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxContacs.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.cbxContacs.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxContacs.FormattingEnabled = true;
            this.cbxContacs.HorizontalScrollbar = true;
            this.cbxContacs.Location = new System.Drawing.Point(34, 319);
            this.cbxContacs.Margin = new System.Windows.Forms.Padding(2);
            this.cbxContacs.Name = "cbxContacs";
            this.cbxContacs.Size = new System.Drawing.Size(250, 238);
            this.cbxContacs.TabIndex = 19;
            this.cbxContacs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbxContacs_ItemCheck);
            // 
            // rbxNoContacts
            // 
            this.rbxNoContacts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rbxNoContacts.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.rbxNoContacts.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbxNoContacts.Location = new System.Drawing.Point(34, 319);
            this.rbxNoContacts.Name = "rbxNoContacts";
            this.rbxNoContacts.Size = new System.Drawing.Size(250, 240);
            this.rbxNoContacts.TabIndex = 16;
            this.rbxNoContacts.Text = "No contacts found available";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ChatApp_CMPG315.Properties.Resources.icons8_close_window_48;
            this.pictureBox1.Location = new System.Drawing.Point(566, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbxGroupMembers
            // 
            this.lbxGroupMembers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbxGroupMembers.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbxGroupMembers.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbxGroupMembers.FormattingEnabled = true;
            this.lbxGroupMembers.ItemHeight = 18;
            this.lbxGroupMembers.Items.AddRange(new object[] {
            "No members added to group"});
            this.lbxGroupMembers.Location = new System.Drawing.Point(318, 319);
            this.lbxGroupMembers.Name = "lbxGroupMembers";
            this.lbxGroupMembers.Size = new System.Drawing.Size(252, 238);
            this.lbxGroupMembers.TabIndex = 22;
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
            this.btnCreateGroup.Location = new System.Drawing.Point(178, 580);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(251, 36);
            this.btnCreateGroup.TabIndex = 9;
            this.btnCreateGroup.Text = "➕Create Group";
            this.btnCreateGroup.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGroupName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGroupName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGroupName.BorderSize = 3;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGroupName.Location = new System.Drawing.Point(158, 226);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupName.Multiline = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Padding = new System.Windows.Forms.Padding(7);
            this.txtGroupName.PasswordChar = false;
            this.txtGroupName.Size = new System.Drawing.Size(240, 31);
            this.txtGroupName.TabIndex = 23;
            this.txtGroupName.Texts = "";
            this.txtGroupName.UnderlinedStyle = false;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 656);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lbxGroupMembers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.cbxContacs);
            this.Controls.Add(this.rbxNoContacts);
            this.MaximumSize = new System.Drawing.Size(610, 695);
            this.MinimumSize = new System.Drawing.Size(610, 695);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CButton btnCreateGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cbxContacs;
        private System.Windows.Forms.RichTextBox rbxNoContacts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxGroupMembers;
        private CTextBox txtGroupName;
    }
}