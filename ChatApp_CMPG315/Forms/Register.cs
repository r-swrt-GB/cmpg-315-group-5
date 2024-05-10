using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

        public bool CheckIfUserExist(string email)
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

        public User RegisterUser(string email, string password, string name, string lastName)
        {
            if (CheckIfUserExist(email))
            {
                DisplayWarning("This email is already associated with an account.");

                return null;
            }

            var database = FirestoreHelper.Database;
            var data = CreateUserProfile(email, password, name, lastName);

            DocumentReference documentReference = database.Collection("users").Document(data.Email);
            documentReference.SetAsync(data);

            MessageBox.Show("Registration successful! Get ready to slap 🙌", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return data;
        }

        public User CreateUserProfile(string email, string password, string name, string lastName)
        {
            return new User()
            {
                Email = email,
                Password = password,
                Name = name,
                LastName = lastName,
                ContactEmails = new List<string> { } 
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

        public void DisplayWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public bool ValidateRegister(string email, string password, string confirmPassword, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                DisplayWarning("Name field is required.");
                cTxtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                DisplayWarning("Surname field is required.");
                cTxtSName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                DisplayWarning("Email field is required.");
                cTxtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                DisplayWarning("Password field is required.");
                cTxtPassword.Focus();
                return false;
            }

            if (password != confirmPassword)
            {
                DisplayWarning("Passwords do not match.");
                cTbxConfirmPassword.Texts = ""; 
                cTxtPassword.Focus();
                return false;
            }

            if (!IsValidEmail(email))
            {
                DisplayWarning("Invalid email. Please enter a valid email and try again.");
                cTxtEmail.Focus();
                return false;
            }

            return true;
        }

        private void cRegAcc_Click(object sender, EventArgs e)
        {
            string password = cTxtPassword.Texts;
            string confirmPassword = cTbxConfirmPassword.Texts;
            string email = cTxtEmail.Texts;
            string name = cTxtName.Texts;
            string lastName = cTxtSName.Texts;

            if (ValidateRegister(email, password, confirmPassword, name, lastName))
            {
                password = HashPassword(password);
                var user = RegisterUser(email, password, name, lastName);

                if (user != null)
                {
                    ChatForm chat = new ChatForm(user);
                    this.Hide();
                    chat.Show();
                }
            }
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

        public void ToggleConfirmPassword()
        {
            //For password visibility or not if the eye next to the password field is clicked
            if (cTbxConfirmPassword.PasswordChar == true)
            {
                cTbxConfirmPassword.PasswordChar = false;
            }
            else
            {
                cTbxConfirmPassword.PasswordChar = true;
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            TogglePassword();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            TogglePassword();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ToggleConfirmPassword();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            ToggleConfirmPassword();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
