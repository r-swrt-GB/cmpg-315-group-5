using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class ProfilePage : Form
    {
        private string name;
        private string surname;
        private string email;

        private User user;

        public ProfilePage(User user)
        {
            InitializeComponent();

            this.user = user;

            name = user.Name;
            surname = user.LastName;
            email = user.Email;

            cTxtName.Texts = name;
            cTxtSurname.Texts = surname;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm(user);
            this.Close();
            chat.Show();
        }

        public void DisplayWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool ValidateProfileDetails(string password, string name, string surname)
        {

            if (string.IsNullOrEmpty(name))
            {
                DisplayWarning("Name field is required.");
                cTxtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(surname))
            {
                DisplayWarning("Surname field is required.");
                cTxtSurname.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                DisplayWarning("Password field is required.");
                cTxtPassword.Focus();
                return false;
            }

            return true;
        }

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

        private async void cRegAcc_Click(object sender, EventArgs e)
        {
            string newName = cTxtName.Texts;
            string newSurname = cTxtSurname.Texts;

            if (cTxtPassword.Texts != cTxtConfirmPassword.Texts)
            {
                DisplayWarning("Passwords do not match.");
                cTxtConfirmPassword.Texts = "";
                cTxtPassword.Focus();

                return;
            }

            string newPassword = HashPassword(cTxtPassword.Texts);

            if (ValidateProfileDetails(cTxtPassword.Texts, newName, newSurname))
            {
                FirestoreDb database = FirestoreHelper.Database;

                DocumentReference docRef = database.Collection("users").Document(email);

                Dictionary<string, object> updates = new Dictionary<string, object>
                {
                    { "Name", newName },
                    { "LastName", newSurname },
                    { "Password", newPassword }
                };

                await docRef.UpdateAsync(updates);

                MessageBox.Show("Profile details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DeleteProfile()
        {
            FirestoreDb database = FirestoreHelper.Database;


            CollectionReference usersRef = database.Collection("users");
            QuerySnapshot snapshot = await usersRef.WhereEqualTo("Email", email).GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                await document.Reference.DeleteAsync();
            }
            MessageBox.Show("Profile has been succefully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DeleteProfile();

                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChatForm mainForm = new ChatForm(user);
            this.Close();
            mainForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TogglePassword()
        {
            if (cTxtPassword.PasswordChar == true)
            {
                cTxtPassword.PasswordChar = false;
            }
            else if (cTxtPassword.PasswordChar == false)
            {
                cTxtPassword.PasswordChar = true;
            }
        }

        private void ToggleConfirmPassword()
        {
            if (cTxtConfirmPassword.PasswordChar == true)
            {
                cTxtConfirmPassword.PasswordChar = false;
            }
            else if (cTxtConfirmPassword.PasswordChar == false)
            {
                cTxtConfirmPassword.PasswordChar = true;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            TogglePassword();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            TogglePassword();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            ToggleConfirmPassword();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            ToggleConfirmPassword();
        }
    }
}
