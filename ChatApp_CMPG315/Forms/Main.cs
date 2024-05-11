﻿using ChatApp_CMPG315.Classes;
using ChatApp_CMPG315.Forms;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatApp_CMPG315
{
    public partial class ChatForm : Form
    {
        public string userEmail;
        public string receiver;

        private User user;
        private List<Groups> groups;
        private FirestoreDb database = FirestoreHelper.Database;

        private System.Timers.Timer timer;

        public ChatForm(User user, List<Groups> groups)
        {
            InitializeComponent();

            this.user = user;
            this.groups = groups;

            userEmail = user.Email;

            // SetupRealTimeMessageListener(database, userEmail, recipientEmail, lstMessages);

            PopulateUserEmails();
            //SetupRealTimeMessageListener(database, userEmail, recipientEmail,lstMessages);
            //SetupTimer();
        }

        private void SetupTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)async delegate
            {
                List<Messages> newMessages = await GetMessagesBetweenUsers(database, userEmail, receiver);
                //List<string> formattedMessages = newMessages.Select(m => FormatMessage(m, userEmail)).ToList();

                List<string> formattedMessages = new List<string> { };

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

        public async Task SendMessageAsync(FirestoreDb database, string senderEmail, string recipientEmail, string messageBody)
        {

            //Create message
            Messages newMessage = new Messages()
            {
                body = messageBody,
                created_at = DateTime.UtcNow,//UtcNwo used for FireStore requirement
                sender_id = senderEmail,
                read_at = null,
                recipient_id = recipientEmail

            };

            //Get firestore unique ID
            CollectionReference messagesCollection = database.Collection("messages");
            await messagesCollection.AddAsync(newMessage);

            string messagePrefix = "You: ";
            string formattedMessage = newMessage.body;
            string messageDate = $"Message sent: {newMessage.created_at.ToString("yyyy-MM-dd HH:mm:ss")}"; // Add "Message sent: " before the time

            lstMessages.Items.Add($"{messagePrefix}{formattedMessage}");
            lstMessages.Items.Add(messageDate);
            lstMessages.Items.Add("");
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

        private async Task LoadInitialMessages(FirestoreDb database, string senderEmail, string recipientEmail, string receiverName)
        {
            lstMessages.Items.Clear();

            List<Messages> messages = await GetMessagesBetweenUsers(database, senderEmail, recipientEmail);

            if (messages == null || messages.Count == 0)
            {
                lstMessages.Items.Add("No messages have been sent. Be the first to say hi!");
            }
            else
            {
                foreach (var message in messages)
                {
                    string messagePrefix = message.sender_id == senderEmail ? $"{user.Name} {user.LastName}: " : $"{receiverName}: ";
                    string formattedMessage = message.body;
                    string messageDate = $"Message sent: {message.created_at.ToString("yyyy-MM-dd HH:mm:ss")}"; // Add "Message sent: " before the time

                    lstMessages.Items.Add($"{messagePrefix}{formattedMessage}");
                    lstMessages.Items.Add(messageDate);

                    lstMessages.Items.Add("");
                }
            }
        }

        private async Task LoadInitialGroupMessages(FirestoreDb database, string senderEmail, string groupTitle)
        {
            lstMessages.Items.Clear();

            QuerySnapshot querySnapshot = await database.Collection("messages")
                .WhereEqualTo("recipient_id", groupTitle)
                .GetSnapshotAsync();

            List<Messages> messages = new List<Messages>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                Messages message = documentSnapshot.ConvertTo<Messages>();
                messages.Add(message);
            }

            if (messages == null || messages.Count == 0)
            {
                lstMessages.Items.Add("No messages have been sent. Be the first to say hi!");
            }
            else
            {
                foreach (var message in messages)
                {
                    string messagePrefix = message.sender_id == senderEmail ? "You: " : $"{message.sender_id}: ";

                    lstMessages.Items.Add($"{messagePrefix}{message.body}");
                    lstMessages.Items.Add($"Message sent: {message.created_at.ToString("yyyy-MM-dd HH:mm:ss")}"); // Date on a new line

                    lstMessages.Items.Add("");
                }
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

        public void PopulateUserEmails()
        {
            lstUsers.Items.Clear();

            if (user.ContactUsers == null && user.ContactUsers.Count == 0 && groups == null && groups.Count == 0)
            {
                lstUsers.Items.Add("No contacts have been added");
            }
            else
            {
                foreach (User user in user.ContactUsers)
                {
                    if (string.IsNullOrEmpty(user.Email))
                    {
                        lstUsers.Items.Add(user.Name);
                        break;
                    }

                    lstUsers.Items.Add(user.Name + " " + user.LastName + " (" + user.Email + ")");
                }

                foreach (Groups group in groups)
                {
                    lstUsers.Items.Add(group.title);
                    break;
                }
            }
        }




        private void Main_Load(object sender, EventArgs e)
        {
            //make profile pic round for user
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userProfile.Width - 3, userProfile.Height - 3);
            Region rg = new Region(gp);
            userProfile.Region = rg;

            lblEmail.Text = "";
            lblChatterUsername.Text = "Select a contact to continue the conversation";
        }

        private async void cButton3_Click(object sender, EventArgs e)
        {
            string recipientEmail = receiver;
            string senderEamil = userEmail;
            string messageBody = txtbxSendMessage.Texts;

            txtbxSendMessage.Texts = null;
            lstMessages.Items.Clear();
            await SendMessageAsync(database, senderEamil, recipientEmail, messageBody);
            // await LoadInitialMessages(database, userEmail, receiver);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopulateUserEmails();
        }

        private void userProfile_Click(object sender, EventArgs e)
        {
            //user profile on click

            ProfilePage prof = new ProfilePage(user, groups);
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

        public string ExtractTextBeforeBrackets(string input)
        {
            string pattern = @"^(.*?)\(";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }
            else
            {
                return null;
            }
        }

        public bool IsContact(string contactTitle)
        {
            int openingBracketIndex = contactTitle.IndexOf('(');
            if (openingBracketIndex == -1)
            {
                return false;
            }

            int closingBracketIndex = contactTitle.IndexOf(')');
            if (closingBracketIndex == -1)
            {
                return false;
            }

            return true;
        }

        public Groups GetGroupFromName(string groupName)
        {
            Groups selectedGroup = null;

            foreach (Groups group in groups)
            {
                if (group.title == groupName)
                {
                    selectedGroup = group;
                    break;
                }
            }

            return selectedGroup;
        }


        private async void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                txtbxSendMessage.Texts = "Type your message here...";

                if (IsContact(lstUsers.SelectedItem.ToString()))
                {
                    btnSendPrivateMessage.Show();
                    btnSendGroupMessage.Hide();

                    string selectedEmail = ExtractTextBetweenBrackets(lstUsers.SelectedItem.ToString());
                    string selectedUser = ExtractTextBeforeBrackets(lstUsers.SelectedItem.ToString());

                    receiver = selectedEmail;

                    lblChatterUsername.Text = selectedUser;
                    lblEmail.Text = selectedEmail;

                    await LoadInitialMessages(database, user.Email, receiver, selectedUser);
                }
                else
                {
                    btnSendPrivateMessage.Hide();
                    btnSendGroupMessage.Show();

                    Groups selectedGroup = GetGroupFromName(lstUsers.SelectedItem.ToString());

                    if (selectedGroup != null)
                    {
                        lblChatterUsername.Text = selectedGroup.title;

                        lblEmail.Text = $"Created at: {selectedGroup.created_at}, Created by: {selectedGroup.created_by}";

                        await LoadInitialGroupMessages(database, user.Email, selectedGroup.title);
                    } else
                    {
                        lstMessages.Items.Add("Could not load group messages. Please try again.");
                    }
                }
            }
        }

        private void ChatForm_Shown(object sender, EventArgs e)
        {
            PopulateUserEmails();
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            AddUsers users = new AddUsers(user, groups);

            users.Show();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            AddGroup users = new AddGroup(user, groups);

            Hide();
            users.Show();
        }

        private void txtbxSendMessage_Click(object sender, EventArgs e)
        {
            if (txtbxSendMessage.Texts == "Type your message here...")
            {
                txtbxSendMessage.Texts = "";
            }
        }

        private async void btnSendGroupMessage_Click(object sender, EventArgs e)
        {
            string recipientEmail = lblChatterUsername.Text;
            string senderEamil = user.Email;
            string messageBody = txtbxSendMessage.Texts;

            txtbxSendMessage.Texts = "Type your message here...";

            await SendMessageAsync(database, senderEamil, recipientEmail, messageBody);
        }
    }
}
