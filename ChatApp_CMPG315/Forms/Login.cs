using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChatApp_CMPG315
{
    public partial class Login : Form
    {
        public async Task<User> GetUserByEmail(FirestoreDb database, string email)
        {
            DocumentReference docRef = database.Collection("users").Document(email);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<User>();
            }

            return null; 
        }


        public bool verifyPassword(string password, string passwordhash)
        {
            byte[] hashBytes = Convert.FromBase64String(passwordhash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            // Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            // Compare the results
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;
        }

        public void loginUser(string email)
        {
            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("users").Document(email);
            User user = documentReference.GetSnapshotAsync().Result.ConvertTo<User>();
        }

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

        private async void cButton1_Click(object sender, EventArgs e)
        {
            string email = cTxtUserName.Texts; 
            string password = cTxtPassword.Texts;

            FirestoreDb database = FirestoreHelper.Database;

            User user = await GetUserByEmail(database, email);
            if (user != null && verifyPassword(password, user.Password))
            {
                ChatForm chat = new ChatForm(email);
                this.Hide();
                chat.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }
    }
}
