using Google.Cloud.Firestore;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Text_Message_CMPG_315_Poject.Classes;

namespace Text_Message_CMPG_315_Poject.Forms
{
    public partial class frmRegister : Form
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

        public bool verifyPassword(string password, string passwordhash)
        {
            byte[] hashBytes = Convert.FromBase64String(passwordhash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;
        }

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnNavigateToLogin_Click(object sender, EventArgs e)
        {
            navigateToLogin();
        }

        public void navigateToLogin()
        {
            frmLogin loginForm = new frmLogin();

            loginForm.Show();

            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = tbxPassword.Text.Trim();
            string confirmPassword = tbxPassword.Text.Trim();

            password = HashPassword(password);

            if (verifyPassword(confirmPassword, password))
            {
                string email = tbxEmail.Text.Trim();

                if (email == null || password == null)
                {
                    MessageBox.Show("Please enter a valid email and password");

                    return;
                }
                registerUser(email, password);
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        public User createUserProfile(string email, string password)
        {
            return new User()
            {
                Email = email,
                Password = password,
            };
        }

        public void registerUser(string email, string password)
        {
            if (checkIfUserExist(email))
            {
                MessageBox.Show("This email is already associated with an account");
            }

            var database = FirestoreHelper.Database;
            var data = createUserProfile(email, password);

            DocumentReference documentReference = database.Collection("users").Document(data.Email);
            documentReference.SetAsync(data);
            MessageBox.Show("Registration successful!");
        }

        public bool checkIfUserExist(string email)
        {

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
    }
}
