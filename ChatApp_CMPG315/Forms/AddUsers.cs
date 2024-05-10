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

namespace ChatApp_CMPG315
{
    public partial class AddUsers : Form
    {
        public string userEmail = "";

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


        private void btnCreateGroup_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;

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
            selectedUsers = cbxUsers.Text + '\n' + selectedUsers;
            richSelectedUsers.Text = selectedUsers;
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            //cbxUsers.items word gefull met database users (users wat die persoon will add na die database)

            //test
            cbxUsers.Items.Add("name");
            cbxUsers.Items.Add("Surname");
            cbxUsers.Items.Add("User");
        }

        private void btnSlap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                MessageBox.Show("Enter the email of a user");
                return;
            }
            else 
            {
                MessageBox.Show("Added successfully");
            }

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
    }
}
