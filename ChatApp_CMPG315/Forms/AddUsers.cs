using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class AddUsers : Form
    {
        private User user;

        public AddUsers(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public bool ValidateForm(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                displayWarning("Email field is required.");
                cTxtUserName.Focus();
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

        public void displayWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

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

        private async Task<User> ExistingUser(FirestoreDb database, string email)
        {
            User user = await GetUserByEmail(database, email);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        private async Task AddContact(FirestoreDb database, User contact)
        {
            DocumentReference userRef = database.Collection("users").Document(user.Email);

            DocumentSnapshot userSnapshot = await userRef.GetSnapshotAsync();
            List<string> contacts = userSnapshot.Exists ? userSnapshot.GetValue<List<string>>("ContactEmails") ?? new List<string>() : new List<string>();

            if (contact.Email == user.Email)
            {
                displayWarning("Please do not talk to yourself. Seek help. Seek HR :)");
                return;
            }


            if (!contacts.Contains(contact.Email))
            {
                contacts.Add(contact.Email);
                user.ContactEmails.Append(contact.Email);
                user.ContactUsers.Append(contact);

                await userRef.UpdateAsync("ContactEmails", contacts);

                MessageBox.Show(contact.Name + " " + contact.LastName + " has been successfully added. Happy slapping!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                displayWarning("This person is already added to your contacts.");
                return;
            }

            ChatForm chat = new ChatForm(user);
            Close();
            chat.Show();
        }

        private async void btnSlap_Click(object sender, EventArgs e)
        {
            string contactEmail = cTxtUserName.Texts;

            if (ValidateForm(contactEmail))
            {
                FirestoreDb database = FirestoreHelper.Database;

                User existingUser = await ExistingUser(database, contactEmail);

                if (existingUser != null)
                {
                    await AddContact(database, existingUser);
                }
                else
                {
                    displayWarning("No existing user found with the specified email. Please try again.");
                    return;
                }
            }
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            Close();

            ChatForm chatForm = new ChatForm(user);
            chatForm.Show();
        }
    }
}
