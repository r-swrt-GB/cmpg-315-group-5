using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //make profile pic round for user
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userProfile.Width - 3, userProfile.Height - 3);
            Region rg = new Region(gp);
            userProfile.Region = rg;

            //make person who chatting to pic round
            System.Drawing.Drawing2D.GraphicsPath sp = new System.Drawing.Drawing2D.GraphicsPath();
            sp.AddEllipse(0, 0, chatterProfile.Width - 3, chatterProfile.Height - 3);
            Region sg = new Region(sp);
            chatterProfile.Region = sg;

            this.Width = 915;
            this.Height = 490;
        }

        private void cButton3_Click(object sender, EventArgs e)
        {

        }

        private void cTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void cTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //onclick for create new contact ext
        }

        private void userProfile_Click(object sender, EventArgs e)
        {
            //user profile on click
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //onclickbackbbton
        }
    }
}
