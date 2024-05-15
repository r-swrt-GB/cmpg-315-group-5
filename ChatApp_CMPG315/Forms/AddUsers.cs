using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatApp_CMPG315
{
    public partial class AddUsers : Form
    {
        private User user; 
        private List<Groups> groups;

        public AddUsers(User user, List<Groups> groups)
        {
            InitializeComponent();

            this.user = user;
            this.groups = groups;
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

        private void PopulateCheckboxList(List<User> users)
        {
           /* // iterates through each user in the list
            foreach (User user in users)
            {
                // ensures that the user object is not null, if not, the checkbox lists are populated
                if (!string.IsNullOrEmpty(user?.Email))
                {
                    clbxUsers.Items.Add(user.Email);
                    clbxNewUsers.Items.Add(user.Email);
                }
            } */
        }

        public async Task<List<string>> getGroupNames(FirestoreDb database)
        {
            List<string> names = new List<string>();
            QuerySnapshot snapshot = await database.Collection("groups").GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.ContainsField("title"))
                {
                    string title = document.GetValue<string>("title");
                    if (!string.IsNullOrEmpty(title))
                    {
                        names.Add(title);
                    }
                }
            }

            return names;
        }

        public async void populateCombobox()
        {
           /* FirestoreDb database = FirestoreHelper.Database;

            cbxGroups.Items.Clear();
            List<string> names = await getGroupNames(database);

            cbxGroups.Items.AddRange(names.ToArray());

            if (cbxGroups.Items.Count > 0)
            {
                cbxGroups.SelectedIndex = 0;
               
            } */
        }

        public List<string> GetGroupMembers(CheckedListBox checkedListBox)
        {
            List<string> members = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                members.Add(item.ToString());
            }
            return members;
        }
        public CheckedListBox getSelectedChecklistBox(CheckedListBox checkedListBox)
        {
            return checkedListBox;
        }

        public bool ifGroupExist(string title)
        {
            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("groups").Document(title);
            Groups name = documentReference.GetSnapshotAsync().Result.ConvertTo<Groups>();

            if (name != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task CreateGroup(CheckedListBox checkedListBox, string created_by, string groupDescription, DateTime created_at, string title)
        {
            var database = FirestoreHelper.Database;
            CollectionReference groupsCollection = database.Collection("groups");
            DocumentReference newGroupRef = groupsCollection.Document();

            if (ifGroupExist(title))
            {
                MessageBox.Show("This group already exists!!");
            }

            // the list contains all of the members selected from the checkedlistbox
            List<string> groupMembers = GetGroupMembers(checkedListBox);

            groupMembers.Add(created_by);

            Dictionary<string, object> groupData = new Dictionary<string, object>
            {
                { "participants", groupMembers},
                { "Created_by", created_by},
                { "description", groupDescription },
                { "created_at", created_at },
                { "title", title }
            };

            await newGroupRef.SetAsync(groupData);

            MessageBox.Show("Added!");
            // clears the list for future use
            groupMembers.Clear();
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
                user.ContactEmails.Add(contact.Email);
                user.ContactUsers.Add(contact);

                await userRef.UpdateAsync("ContactEmails", contacts);

                MessageBox.Show(contact.Name + " " + contact.LastName + " has been successfully added. Happy slapping!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                displayWarning("This person is already added to your contacts.");
                return;
            }

            ChatForm chat = new ChatForm(user, groups);
            Close();
            chat.Show();
        }

        private async void btnSlap_Click(object sender, EventArgs e)
        {
            string contactEmail = cTxtUserName.Texts.ToLower();

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
            ChatForm chat = new ChatForm(user, groups);
            chat.Show();
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
