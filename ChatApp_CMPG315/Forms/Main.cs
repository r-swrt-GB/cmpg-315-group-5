﻿using ChatApp_CMPG315.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ChatApp_CMPG315
{
    public partial class ChatForm : Form
    {
        public string userEmail;
        public string receiver;
        public FirestoreDb database = FirestoreHelper.Database;
        private System.Timers.Timer timer;

        private void SetupTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent; 
            timer.Enabled = true; 
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)async delegate {
                List<Messages> newMessages = await GetMessagesBetweenUsers(database, userEmail, receiver);
                List<string> formattedMessages = newMessages.Select(m => FormatMessage(m, userEmail)).ToList();

                if (!IsListBoxContentSame(lstMessages, formattedMessages))
                {
                    lstMessages.Items.Clear();
                    foreach (var message in formattedMessages)
                    {
                        lstMessages.Items.Add(message);
                    }

                    // Scroll to the bottom of the ListBox
                    if (lstMessages.Items.Count > 0)
                        lstMessages.SelectedIndex = lstMessages.Items.Count - 1;
                }
            });
        }


        private string FormatMessage(Messages message, string senderEmail)
        {
            string prefix = message.sender_id == senderEmail ? "You: " : "Them: ";
            string formattedDate = message.created_at.ToString("MMM dd, yyyy HH:mm");
            return $"{prefix} {formattedDate}: {message.body}";
        }

        private bool IsListBoxContentSame(ListBox listBox, List<string> newMessages)
        {
            if (listBox.Items.Count != newMessages.Count)
            {
                return false; 
            }

            for (int i = 0; i < newMessages.Count; i++)
            {
                if (listBox.Items[i].ToString() != newMessages[i])
                {
                    return false; 
                }
            }

            return true;
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

        public async Task<List<Messages>> GetMessagesBetweenUsers(FirestoreDb database, string senderEmail, string receiverEmail)
        {
            List<Messages> messages = new List<Messages>();

            // Fetch messages where userOne is the sender and userTwo is the recipient
            CollectionReference messagesCollection = database.Collection("messages");
            Query queryOne = messagesCollection
                .WhereEqualTo("sender_id", senderEmail)
                .WhereEqualTo("recipient_id", receiverEmail);
            QuerySnapshot snapshotOne = await queryOne.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshotOne.Documents)
            {
                messages.Add(document.ConvertTo<Messages>());
            }

            // Fetch messages where userOne is the recipient and userTwo is the sender
            Query queryTwo = messagesCollection
                .WhereEqualTo("sender_id", receiverEmail)
                .WhereEqualTo("recipient_id", senderEmail);
            QuerySnapshot snapshotTwo = await queryTwo.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshotTwo.Documents)
            {
                messages.Add(document.ConvertTo<Messages>());
            }

            // sort messages by created_at
            messages.Sort((x, y) => DateTime.Compare(x.created_at, y.created_at));

            return messages;
        }

        private async void LoadInitialMessages(FirestoreDb database, string senderEmail, string recipientEmail)
        {
            // Load historical messages between the sender and the new recipient
            List<Messages> messages = await GetMessagesBetweenUsers(database, senderEmail, recipientEmail);
            foreach (var message in messages)
            {
                string prefix = message.sender_id == senderEmail ? "You: " : "Them: ";
                lstMessages.Items.Add($"{prefix} {message.created_at}: {message.body}");
            }
        }

        /*        private void SetupRealTimeMessageListener(FirestoreDb database, string senderEmail, string receiverEmail)
                {
                    CollectionReference messagesCollection = database.Collection("messages");

                    // Listen to messages in both directions
                    Query query = messagesCollection
                        .WhereIn("sender_id", new List<string> { senderEmail, receiverEmail })
                        .WhereIn("recipient_id", new List<string> { senderEmail, receiverEmail })
                        .OrderBy("created_at"); 

                    query.Listen(snapshot =>
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            foreach (DocumentChange change in snapshot.Changes)
                            {
                                if (change.ChangeType == DocumentChange.Type.Added || change.ChangeType == DocumentChange.Type.Modified)
                                {
                                    Messages message = change.Document.ConvertTo<Messages>();
                                    UpdateListBox(message);
                                }
                            }
                        });
                    });
                }


                private void UpdateListBox(Messages message)
                {
                    string prefix = message.sender_id == userEmail ? "You: " : "Them: ";
                    string displayText = $"{prefix} {message.created_at}: {message.body}";
                    lstMessages.Items.Add(displayText);
                    lstMessages.SelectedIndex = lstMessages.Items.Count - 1; // Scroll to the latest message
                }*/
        public async Task<string> FindUserIdByEmail(FirestoreDb database, string email)
        {
            //Soek deur die collections vir die email wie die message moet kry
            CollectionReference usersCollection = database.Collection("users");
            Query query = usersCollection.WhereEqualTo("Email", email);
            //Return al die collections wat == aan die email
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            //Ensure only one email
            if (snapshot.Count == 1)
            {
                DocumentSnapshot userDocument = snapshot.Documents[0];
                return userDocument.Id;
            }
            return null;
        }

        /*public void SetupRealTimeMessageListener(FirestoreDb database, string userOneEmail, string userTwoEmail, ListBox messageDisplayBox)
        {
            Task.Run(async () =>
            {
                string userOneId = await FindUserIdByEmail(database, userOneEmail);
                string userTwoId = await FindUserIdByEmail(database, userTwoEmail);
                if (userOneId == null || userTwoId == null)
                {
                    MessageBox.Show("One or both users not found.");
                    return;
                }

                CollectionReference messagesCollection = database.Collection("messages");

                // Setup listener for messages where userOne is the sender and userTwo is the recipient
                Query queryOne = messagesCollection
                    .WhereEqualTo("sender_id", userOneId)
                    .WhereEqualTo("recipient_id", userTwoId);

                // Setup listener for messages where userOne is the recipient and userTwo is the sender
                Query queryTwo = messagesCollection
                    .WhereEqualTo("sender_id", userTwoId)
                    .WhereEqualTo("recipient_id", userOneId);

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
        }*/


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
            //SetupRealTimeMessageListener(database, userEmail, recipientEmail,lstMessages);
            SetupTimer();
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
/*            FirestoreDb database = FirestoreHelper.Database;
            SetupRealTimeMessageListener(database, userEmail, receiver, lstMessages);*/
        }

        private async void cButton3_Click(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;

            string recipientEmail = receiver;
            string senderEamil = userEmail;
            string messageBody = txtbxSendMessage.Texts;

            txtbxSendMessage.Texts = null;
            lstMessages.Items.Clear();
            await SendMessageAsync(database, senderEamil, recipientEmail, messageBody);
            LoadInitialMessages(database, userEmail, receiver);

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
            FirestoreDb database = FirestoreHelper.Database;
            if (lstUsers.SelectedItem != null)
            {
                lstMessages.Items.Clear();
                string selectedEmail = lstUsers.SelectedItem.ToString();
                receiver = selectedEmail;
                //SetupRealTimeMessageListener(database, userEmail, receiver);
                LoadInitialMessages(database, userEmail, receiver);
            }
        }
    }
}
