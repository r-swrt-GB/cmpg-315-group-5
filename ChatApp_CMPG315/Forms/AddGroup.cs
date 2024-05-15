using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ChatApp_CMPG315.Forms
{
    public partial class AddGroup : Form
    {
        private User user;
        private List<Groups> groups;
        private List<User> selectedUsers = new List<User> { };
        private FirestoreDb database = FirestoreHelper.Database;

        public AddGroup(User user, List<Groups> groups)
        {
            InitializeComponent();
            this.user = user;
            this.groups = groups;
        }

        public void displayWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtGroupName.Texts))
            {

                displayWarning("Group Name field is required.");
                txtGroupName.Focus();

                return false;
            }

            if (selectedUsers.Count == 0)
            {
                displayWarning("Please add participants to group.");

                return false;
            }

            return true;
        }

        private async Task CreateGroup()
        {
            string createdBy = user.Email;

            DateTime createdAt = DateTime.UtcNow;

            List<string> participantEmails = selectedUsers.Select(user => user.Email).ToList();

            string groupTitle = txtGroupName.Texts;

            Dictionary<string, object> newGroup = new Dictionary<string, object>
                {
                    { "created_by", createdBy },
                    { "created_at", createdAt },
                    { "participants", participantEmails },
                    { "title", groupTitle }
                };

            await database.Collection("groups").AddAsync(newGroup);

            //user.ContactEmails.Add(groupTitle);

            Groups group = new Groups()
            {

                created_at = createdAt,
                created_by = createdBy,
                participants = participantEmails,
                title = groupTitle
            
            };

            //user.ContactUsers.Add(groupAsUser);

            groups.Add(group);

            MessageBox.Show("Group created successfully. Happy slapping!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloseCurrentForm();
        }

        private async void btnCreateGroup_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                await CreateGroup();
            }
        }

        public void ClearListBoxes()
        {
            rbxNoContacts.BringToFront();
            lbxGroupMembers.BringToFront();

            cbxContacs.Hide();

            cbxContacs.Items.Clear();
        }

        public void AddContacts()
        {
            if (user.ContactUsers != null && user.ContactUsers.Count > 0)
            {
                foreach (var contact in user.ContactUsers)
                {
                    cbxContacs.Items.Add(contact.Name + " " + contact.LastName + " (" + contact.Email + ")");
                }

                rbxNoContacts.Hide();
                cbxContacs.Show();
                cbxContacs.BringToFront();
            }
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            ClearListBoxes();

            AddContacts();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
        }

        public void CloseCurrentForm()
        {
            ChatForm chatForm = new ChatForm(user, groups);

            chatForm.Show();
            Close();
        }

        public string ExtractTextBetweenBrackets(string input)
        {
            string pattern = @"\((.*?)\)";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }

        private void cbxContacs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string checkedItem = cbxContacs.Items[e.Index].ToString();

            string selectedUserEmail = ExtractTextBetweenBrackets(checkedItem);

            User selectedUser = null;
            foreach (User user in user.ContactUsers)
            {
                if (user.Email == selectedUserEmail)
                {
                    selectedUser = user;
                    break;
                }
            }

            if (e.NewValue == CheckState.Checked)
            {
                if (selectedUser != null && !selectedUsers.Contains(selectedUser))
                {
                    selectedUsers.Add(selectedUser);
                }
            }
            else
            {
                if (selectedUser != null && selectedUsers.Contains(selectedUser))
                {
                    selectedUsers.Remove(selectedUser);
                }
            }

            UpdateSelectedUsers();
        }

        private void UpdateSelectedUsers()
        {
            lbxGroupMembers.Items.Clear();

            foreach (var user in selectedUsers)
            {
                string itemText = user.Name + " " + user.LastName + " (" + user.Email + ")";
                lbxGroupMembers.Items.Add(itemText);
            }
        }
    }
}
