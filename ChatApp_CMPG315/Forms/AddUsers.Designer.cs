
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.cTxtUserName = new ChatApp_CMPG315.CTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cButton1 = new ChatApp_CMPG315.CButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlap = new ChatApp_CMPG315.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(103, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 6);
            this.panel3.TabIndex = 28;
            // 
            // cTxtUserName
            // 
            this.cTxtUserName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cTxtUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTxtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTxtUserName.BorderSize = 3;
            this.cTxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTxtUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cTxtUserName.Location = new System.Drawing.Point(120, 126);
            this.cTxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.cTxtUserName.Multiline = false;
            this.cTxtUserName.Name = "cTxtUserName";
            this.cTxtUserName.Padding = new System.Windows.Forms.Padding(7);
            this.cTxtUserName.PasswordChar = false;
            this.cTxtUserName.Size = new System.Drawing.Size(240, 31);
            this.cTxtUserName.TabIndex = 26;
            this.cTxtUserName.Texts = "";
            this.cTxtUserName.UnderlinedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChatApp_CMPG315.Properties.Resources.icons8_person_48;
            this.pictureBox3.Location = new System.Drawing.Point(88, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(137, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "to add them to your contacts.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please enter the recipient\'s email below to add them";
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.cButton1.BorderRadius = 30;
            this.cButton1.BorderSize = 1;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.Location = new System.Drawing.Point(101, 179);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(130, 35);
            this.cButton1.TabIndex = 22;
            this.cButton1.Text = "Cancel";
            this.cButton1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(190, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 21;
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
            this.btnSlap.Location = new System.Drawing.Point(242, 179);
            this.btnSlap.Name = "btnSlap";
            this.btnSlap.Size = new System.Drawing.Size(130, 35);
            this.btnSlap.TabIndex = 20;
            this.btnSlap.Text = "Add➕";
            this.btnSlap.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSlap.UseVisualStyleBackColor = false;
            this.btnSlap.Click += new System.EventHandler(this.btnSlap_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(475, 255);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cTxtUserName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSlap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(475, 255);
            this.MinimumSize = new System.Drawing.Size(475, 255);
            this.Name = "AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private CTextBox cTxtUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CButton cButton1;
        private System.Windows.Forms.Label label4;
        private CButton btnSlap;
    }
}