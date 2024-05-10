using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class ChatForm : Form
    {
        public string userEmail;
        public string receiver;

        public async Task<string> FindUserIdByEmail(FirestoreDb database, string email)
        {
            CollectionReference usersCollection = database.Collection("users");
            Query query = usersCollection.WhereEqualTo("Email", email);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            //Ensure only one email
            if (snapshot.Count == 1)
            {
                DocumentSnapshot userDocument = snapshot.Documents[0];
                return userDocument.Id;
            }
            return null;
        }

        public async Task<string> FindGroupIdByTitle(FirestoreDb database, string title)
        {
            CollectionReference groupsCollection = database.Collection("groups");
            Query query = groupsCollection.WhereEqualTo("title", title);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Count == 1)
            {
                DocumentSnapshot groupDocument = snapshot.Documents[0];
                return groupDocument.Id;
            }
            return null;
        }

        public async Task SendMessageAsync(FirestoreDb database, string senderEmail, string recipientEmail, string messageBody, string groupTitle = null)
        {

            //Create message
            Messages newMessage = new Messages()
            {
                body = messageBody,
                created_at = DateTime.UtcNow,//UtcNwo used for FireStore requirement
                sender_id = senderEmail,
                read_at = null 

            };

            if (groupTitle != null)
            {
                newMessage.group_id = await FindGroupIdByTitle(database, groupTitle);
            }
            else
            {
                newMessage.recipient_id = recipientEmail;
            }

            //Get firestore unique ID
            CollectionReference messagesCollection = database.Collection("messages");
            DocumentReference newDocRef = await messagesCollection.AddAsync(newMessage);
            MessageBox.Show("Message sent successfully. ID: " + newDocRef.Id);
        }

        public void SetupRealTimeMessageListener(FirestoreDb database, string senderEmail, string receiverEmail, ListBox messageDisplayBox)
        {
            Task.Run(() =>
            {
                CollectionReference messagesCollection = database.Collection("messages");

                // Setup listener for messages where userOne is the sender and userTwo is the recipient
                Query queryOne = messagesCollection
                    .WhereEqualTo("sender_id", senderEmail)
                    .WhereEqualTo("recipient_id", receiverEmail);

                // Setup listener for messages where userOne is the recipient and userTwo is the sender
                Query queryTwo = messagesCollection
                    .WhereEqualTo("sender_id", receiverEmail)
                    .WhereEqualTo("recipient_id", senderEmail);

                // Listen for real-time updates from both queries
                queryOne.Listen(snapshot => HandleDocumentChanges(snapshot, "You: ", messageDisplayBox));
                queryTwo.Listen(snapshot => HandleDocumentChanges(snapshot, "Them: ", messageDisplayBox));
            });
        }

        private void HandleDocumentChanges(QuerySnapshot snapshot, string messagePrefix, ListBox messageDisplayBox)
        {
            foreach (DocumentChange change in snapshot.Changes)
            {
                if (change.ChangeType == DocumentChange.Type.Added)
                {
                    Messages message = change.Document.ConvertTo<Messages>();
                    this.Invoke(new Action(() =>
                    {
                        messageDisplayBox.Items.Add($"{messagePrefix}{message.body} - Sent at: {message.created_at.ToLocalTime()}");
                    }));
                }
            }
        }

        public async Task<List<string>> GetAllUserEmails(FirestoreDb database)
        {
            List<string> userEmails = new List<string>();
            CollectionReference userCollection = database.Collection("users");
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    userEmails.Add(document.Id);
                }
            }
            return userEmails;
        }

        public async void PopulateUserEmails()
        {
            FirestoreDb database = FirestoreHelper.Database; 
            List<string> userEmails = await GetAllUserEmails(database);

            lstUsers.Items.Clear(); 
            foreach (string email in userEmails)
            {
                lstUsers.Items.Add(email); 
            }
        }


        public ChatForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            FirestoreDb database = FirestoreHelper.Database;
            string recipientEmail = receiver;
            string groupTitle = "Group_Example_1";
            SetupRealTimeMessageListener(database, userEmail, recipientEmail, lstMessages);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //make profile pic round for user
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userProfile.Width - 3, userProfile.Height - 3);
            Region rg = new Region(gp);
            userProfile.Region = rg;

            //make person who chatting to pic round
            System.Drawing.Drawing2D.GraphicsPath sp = new System.Drawing.Drawing2D.GraphicsPath();
            sp.AddEllipse(0, 0, chatterProfile.Width - 3, chatterProfile.Height - 3);
            Region sg = new Region(sp);
            chatterProfile.Region = sg;

            this.Width = 915;
            this.Height = 490;

            PopulateUserEmails();
        }

        private async void cButton3_Click(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;

            string recipientEmail = receiver;
            string senderEamil = userEmail;
            string messageBody = txtbxSendMessage.Texts;

            await SendMessageAsync(database, senderEamil, recipientEmail, messageBody);
            txtbxSendMessage.Texts = null;

        }

        private void cTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void cTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopulateUserEmails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //onclick for create new contact ext
            AddUsers users = new AddUsers();
            this.Hide();
            users.Show();
        }

        private void userProfile_Click(object sender, EventArgs e)
        {
            //user profile on click

            ProfilePage prof = new ProfilePage();
            this.Hide();
            prof.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //onclickbackbbton
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                lstMessages.Items.Clear();
                string selectedEmail = lstUsers.SelectedItem.ToString();
                receiver = selectedEmail;
                MessageBox.Show("Selected email: " + selectedEmail); // Example usage
            }
        }
    }
}
