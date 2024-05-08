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

namespace ChatApp_CMPG315
{
    public partial class Register : Form
    {
        public string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string hashpassword = Convert.ToBase64String(hashBytes);
            return hashpassword;
        }

        /*Ek dink ons moet steeds die function gebruik vir user registration
         * so ons gaan net nog 'n textbox kort waar ons weer die password vra
         * sodat ons kan seker maak die password word reg ingetik
         * tensy jul voel dis nie nodig nie*/
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

        public bool checkIfUserExist(string email)
        {
            MessageBox.Show("This is the email in checkIfUserExists: " + email);

            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("users").Document(email);
            User user = documentReference.GetSnapshotAsync().Result.ConvertTo<User>();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void registerUser(string email, string password, string name, string lastName)
        {
            if (checkIfUserExist(email))
            {
                MessageBox.Show("This email is already associated with an account");
            }

            var database = FirestoreHelper.Database;
            var data = createUserProfile(email, password, name, lastName);

            DocumentReference documentReference = database.Collection("users").Document(data.Email);
            documentReference.SetAsync(data);
            MessageBox.Show("Registration successful!");
        }

        public User createUserProfile(string email, string password, string name, string lastName)
        {
            return new User()
            {
                Email = email,
                Password = password,
                Name = name,
                LastName = lastName
            };
        }

        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void cRegAcc_Click(object sender, EventArgs e)
        {
            string password = cTxtPassword.Texts;
            string email = cTxtEmail.Texts;
            string name = cTxtName.Texts;
            string lastName = cTxtSName.Texts;

            MessageBox.Show(name + email + lastName + password);

            password = HashPassword(password);
            registerUser(email,password,name,lastName);

            ChatForm chat = new ChatForm();
            this.Hide();
            chat.Show();
        }

        private void cTxtName__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
