using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;
using Text_Message_CMPG_315_Poject.Classes;
using Text_Message_CMPG_315_Poject.Forms;

namespace Text_Message_CMPG_315_Poject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigateToRegister();
        }

        public void navigateToRegister()
        {
            frmRegister frmRegister = new frmRegister();

            this.Hide();

            frmRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text.Trim();
            string password = tbxPassword.Text.Trim();

            if (email == null || password == null)
            {
                MessageBox.Show("Please enter a valid email and password");

                return;
            }

            loginUser(email, password);
        }



        public void loginUser(string email, string password)
        {
            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("users").Document(email);
            User user = documentReference.GetSnapshotAsync().Result.ConvertTo<User>();

            if (user != null && password == user.Password)
            {
                MessageBox.Show("Login successful! Welcome back!");
            }
            else
            {
                MessageBox.Show("Incorrect email or password");
            }
        }
    }
}
