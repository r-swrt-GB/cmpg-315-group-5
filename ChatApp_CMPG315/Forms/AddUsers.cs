using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatApp_CMPG315
{
    public partial class AddUsers : Form
    {
        public string userEmail { get; set; }


        

        string selectedUsers = "";

        public AddUsers()
        {
            InitializeComponent();
        }

        // list that contains all of the user email addresses
        public async Task<List<User>> GetAllUsers(FirestoreDb database)
        {
            // gets reference to the users collection in the database
            CollectionReference userCollection = database.Collection("users");

            //retrieve a snapshot of the documents in the collection
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();


            // initialise a list to store the user objects
            List<User> users = new List<User>();

            // iterate through each document snapshot in the snapshot
            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                // convert the snapshots to a user object and adds it to the list
                User user = documentSnapshot.ConvertTo<User>();
                users.Add(user);
            }
            return users;
        }

        private void PopulateCheckboxList(List<User> users)
        {
            // iterates through each user in the list
            foreach (User user in users)
            {
                // ensures that the user object is not null, if not, the checkbox lists are populated
                if (!string.IsNullOrEmpty(user?.Email))
                {
                    clbxUsers.Items.Add(user.Email);
                    clbxNewUsers.Items.Add(user.Email);
                }
            }
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
            FirestoreDb database = FirestoreHelper.Database;

            cbxGroups.Items.Clear();
            List<string> names = await getGroupNames(database);

            cbxGroups.Items.AddRange(names.ToArray());

            if (cbxGroups.Items.Count > 0)
            {
                cbxGroups.SelectedIndex = 0;
               
            }
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


        private void btnCreateGroup_Click(object sender, EventArgs e)
        {

           // string email = txtEmail.Text;

            //groupName is empty
            if (string.IsNullOrEmpty(selectedUsers) && string.IsNullOrEmpty(txtGroupName.Texts))
            {
                MessageBox.Show("Please enter a Group Name and Select users in order to create a group");
                return;
            }
            else if (string.IsNullOrEmpty(txtGroupName.Texts))
            {
                MessageBox.Show("The group must have a name");
                return;
            }
            else if (string.IsNullOrEmpty(selectedUsers))
            {
                MessageBox.Show("Must at least select one user for group");
                return;
            }
            else
            {

                //rest of database functions
                MessageBox.Show("Group Created Successfully");
            }

            ChatForm chat = new ChatForm(userEmail);
            this.Hide();
            chat.Show();
        }

        private void cbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* selectedUsers = cbxGroups.Text + '\n' + selectedUsers;
            richSelectedUsers.Text = selectedUsers;*/
        }

        private async void AddUsers_Load(object sender, EventArgs e)
        {
            //cbxUsers.items word gefull met database users (users wat die persoon will add na die database)

            //test
           // cbxUsers.Items.Add("name");
           // cbxUsers.Items.Add("Surname");
           // cbxUsers.Items.Add("User");

            FirestoreDb database = FirestoreHelper.Database;

            Login login = new Login();
            

            MessageBox.Show(userEmail);

            List<User> users = await GetAllUsers(database);

            PopulateCheckboxList(users);
            populateCombobox();
        }

        private void btnSlap_Click(object sender, EventArgs e)
        {
          /*  if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                MessageBox.Show("Enter the email of a user");
                return;
            }
            else 
            {
                MessageBox.Show("Added successfully");
            }
*/
            ChatForm chat = new ChatForm(userEmail);
            this.Hide();
            chat.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cButton4_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm(userEmail);
            this.Hide();
            chat.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
