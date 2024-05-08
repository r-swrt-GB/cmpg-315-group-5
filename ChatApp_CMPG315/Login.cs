using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatApp_CMPG315
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //To Display the register form
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //For password visibility or not if the eye next to the password field is clicked
            if (cTxtPassword.PasswordChar == true)
            {
               cTxtPassword.PasswordChar = false;
            }
            else
            {
                cTxtPassword.PasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm();
            this.Hide();
            chat.Show();
        }
    }
}
