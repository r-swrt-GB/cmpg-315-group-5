
namespace ChatApp_CMPG315
{
    partial class Main
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
            this.cButton3 = new ChatApp_CMPG315.CButton();
            this.cTextBox1 = new ChatApp_CMPG315.CTextBox();
            this.cTextBox2 = new ChatApp_CMPG315.CTextBox();
            this.cTextBox3 = new ChatApp_CMPG315.CTextBox();
            this.SuspendLayout();
            // 
            // cButton3
            // 
            this.cButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton3.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.cButton3.BorderRadius = 30;
            this.cButton3.BorderSize = 2;
            this.cButton3.FlatAppearance.BorderSize = 0;
            this.cButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton3.ForeColor = System.Drawing.Color.White;
            this.cButton3.Location = new System.Drawing.Point(310, 445);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(150, 40);
            this.cButton3.TabIndex = 2;
            this.cButton3.Text = "cButton3";
            this.cButton3.TextColor = System.Drawing.Color.White;
            this.cButton3.UseVisualStyleBackColor = false;
            this.cButton3.Click += new System.EventHandler(this.cButton3_Click);
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cTextBox1.Location = new System.Drawing.Point(413, 226);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Multiline = false;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.PasswordChar = false;
            this.cTextBox1.Size = new System.Drawing.Size(250, 35);
            this.cTextBox1.TabIndex = 3;
            this.cTextBox1.Texts = "";
            this.cTextBox1.UnderlinedStyle = true;
            // 
            // cTextBox2
            // 
            this.cTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox2.BorderFocusColor = System.Drawing.Color.Blue;
            this.cTextBox2.BorderSize = 2;
            this.cTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cTextBox2.Location = new System.Drawing.Point(95, 304);
            this.cTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox2.Multiline = false;
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox2.PasswordChar = true;
            this.cTextBox2.Size = new System.Drawing.Size(250, 35);
            this.cTextBox2.TabIndex = 4;
            this.cTextBox2.Texts = "";
            this.cTextBox2.UnderlinedStyle = false;
            // 
            // cTextBox3
            // 
            this.cTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox3.BorderFocusColor = System.Drawing.Color.Crimson;
            this.cTextBox3.BorderSize = 2;
            this.cTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cTextBox3.Location = new System.Drawing.Point(95, 226);
            this.cTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox3.Multiline = false;
            this.cTextBox3.Name = "cTextBox3";
            this.cTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox3.PasswordChar = false;
            this.cTextBox3.Size = new System.Drawing.Size(250, 35);
            this.cTextBox3.TabIndex = 5;
            this.cTextBox3.Texts = "";
            this.cTextBox3.UnderlinedStyle = false;
            this.cTextBox3._TextChanged += new System.EventHandler(this.cTextBox3__TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 562);
            this.Controls.Add(this.cTextBox3);
            this.Controls.Add(this.cTextBox2);
            this.Controls.Add(this.cTextBox1);
            this.Controls.Add(this.cButton3);
            this.Name = "Main";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CButton cButton3;
        private CTextBox cTextBox1;
        private CTextBox cTextBox2;
        private CTextBox cTextBox3;
    }
}

