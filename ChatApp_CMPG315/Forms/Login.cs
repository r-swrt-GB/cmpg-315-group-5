using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class Login : Form
    {
        public string userEmail
        {
            get { return cTxtUserName.Text; }
            set { cTxtUserName.Texts = value; }
        }

        public async Task<User> GetUserByEmail(FirestoreDb database, string email)
        {
            DocumentReference docRef = database.Collection("users").Document(email);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                User user = snapshot.ConvertTo<User>();

                List<User> contactUsers = new List<User>();
                foreach (string contactEmail in user.ContactEmails)
                {
                    if (!string.IsNullOrEmpty(contactEmail))
                    {
                        DocumentReference contactDocRef = database.Collection("users").Document(contactEmail);
                        DocumentSnapshot contactSnapshot = await contactDocRef.GetSnapshotAsync();
                        if (contactSnapshot.Exists)
                        {
                            User contactUser = contactSnapshot.ConvertTo<User>();
                            contactUsers.Add(contactUser);
                        }
                    }
                }

                user.ContactUsers = contactUsers;

                return user;
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

        //Replaced with GetUserByEmail
        /*public void loginUser(string email)
        {
            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("users").Document(email);
            User user = documentReference.GetSnapshotAsync().Result.ConvertTo<User>();
        }*/

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

        public void TogglePassword()
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

        public void displayWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public bool ValidateLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                displayWarning("Email field is required.");
                cTxtUserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                displayWarning("Password field is required.");
                cTxtPassword.Focus();
                return false;
            }

            if (!IsValidEmail(email))
            {
                displayWarning("Invalid email. Please enter a valid email and try again.");
                cTxtUserName.Focus();
                return false;
            }

            return true;
        }


        private async void cButton1_Click(object sender, EventArgs e)
        {
            string email = cTxtUserName.Texts;
            string password = cTxtPassword.Texts;

            if (ValidateLogin(email, password))
            {
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

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            TogglePassword();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            TogglePassword();
        }
    }
}
