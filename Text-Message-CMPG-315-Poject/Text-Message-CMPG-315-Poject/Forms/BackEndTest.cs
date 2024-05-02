using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Text_Message_CMPG_315_Poject.Classes;
using Text_Message_CMPG_315_Poject.Forms;



//Info
//Async maak dat die program kan aanhou run al is die function nog nie klaar nie
//Task is 'n async function
namespace Text_Message_CMPG_315_Poject.Forms
{
    public partial class BackEndTest : Form
    {
        private List<Messages> messageBuffer = new List<Messages>();
        private object bufferLock = new object();

        public BackEndTest()
        {
            InitializeComponent();
            FirestoreDb database = FirestoreHelper.Database;
            string recipientEmail = "receiver@example.com";
            string senderEmail = "sender@example.com";
            SetupRealTimeMessageListener(database, senderEmail, recipientEmail, listBox1);
            //InitializeTimer();
        }

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

        public async Task SendMessageAsync(FirestoreDb database, string senderEmail, string recipientEmail, string messageBody)
        {
            //Ensure email receiver and sender exists
            string senderId = await FindUserIdByEmail(database, senderEmail);
            string recipientId = await FindUserIdByEmail(database, recipientEmail);

            if (recipientId == null)
            {
                MessageBox.Show("Recipient not found.");
                return;
            }

            //Create message
            Messages newMessage = new Messages()
            {
                body = messageBody,
                created_at = DateTime.UtcNow,//UtcNwo used for FireStore requirement
                recipient_id = recipientId,
                sender_id = senderId,
                read_at = null  //message hasn't been read 
            };

            //Get firestore unique ID
            CollectionReference messagesCollection = database.Collection("messages");
            DocumentReference newDocRef = await messagesCollection.AddAsync(newMessage);
            MessageBox.Show("Message sent successfully. ID: " + newDocRef.Id);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;

            // Example usage of sending a message
            string senderEmail = "sender@example.com";
            string recipientEmail = "receiver@example.com";
            string messageBody = "This is another test message";

            await SendMessageAsync(database, senderEmail, recipientEmail, messageBody);
        }

        public void SetupRealTimeMessageListener(FirestoreDb database, string userOneEmail, string userTwoEmail, ListBox messageDisplayBox)
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
                queryOne.Listen(snapshot => HandleDocumentChanges(snapshot, messageDisplayBox));
                queryTwo.Listen(snapshot => HandleDocumentChanges(snapshot, messageDisplayBox));
            });


        }

        // retrieve all users from the database
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
        
        // populates the checkbox lists with user emails
        private void PopulateCheckboxList(List<User> users)
        {
            // iterates through each user in the list
            foreach (User user in users)
            {
                // ensures that the user object is not null, if not, the checkbox lists are populated
                if (!string.IsNullOrEmpty(user?.Email))
                {
                    checkedListBox1.Items.Add(user.Email);
                    checkedListBox2.Items.Add(user.Email);  
                }
            }
        }

        private void HandleDocumentChanges(QuerySnapshot snapshot, ListBox messageDisplayBox)
        {
            // Add new messages to the buffer
            foreach (DocumentChange change in snapshot.Changes)
            {
                if (change.ChangeType == DocumentChange.Type.Added)
                {
                    Messages message = change.Document.ConvertTo<Messages>();
                    lock (bufferLock)
                    {
                        messageBuffer.Add(message);
                    }
                }
            }

            // Update the ListBox from the buffer
            UpdateListBox(messageDisplayBox, "sender@example.com");
        }

        private void UpdateListBox(ListBox messageDisplayBox, string currentUserEmail)
        {
            // Make a copy of the buffer and sort it
            List<Messages> messagesToDisplay;
            lock (bufferLock)
            {
                messagesToDisplay = new List<Messages>(messageBuffer);
                messageBuffer.Clear();
            }

            // Sort messages by creation time
            messagesToDisplay.Sort((x, y) => x.created_at.CompareTo(y.created_at));

            // Safely update the UI
            this.Invoke(new Action(() =>
            {
                messageDisplayBox.Items.Clear();  // Clear the list to manage duplicates appropriately
                foreach (var message in messagesToDisplay)
                {
                    // Check if the current user is the sender or recipient
                    if (message.sender_id == currentUserEmail)
                    {
                        messageDisplayBox.Items.Add($"You: {message.body} - Sent at: {message.created_at.ToLocalTime()}");
                    }
                    else if (message.recipient_id == currentUserEmail)
                    {
                        messageDisplayBox.Items.Add($"{message.sender_id}: {message.body} - Sent at: {message.created_at.ToLocalTime()}");
                    }
                }
            }));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void BackEndTest_Load(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;

            List<User> users = await GetAllUsers(database);

            PopulateCheckboxList(users);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}