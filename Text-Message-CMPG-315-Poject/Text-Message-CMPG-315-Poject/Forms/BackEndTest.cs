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
        public BackEndTest()
        {
            InitializeComponent();
            FirestoreDb database = FirestoreHelper.Database;
            //This must be the login email
            string recipientEmail = "receiver@example.com";
            string senderEmail = "sender@example.com";
            SetupRealTimeMessageListener(database, senderEmail, recipientEmail, listBox1);
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

        public Messages CreateMessage(string body, string groupId, string recipientId, string senderId, DateTime sent, DateTime? read = null)
        {
            return new Messages()
            {
                body = body,
                group_id = groupId,
                recipient_id = recipientId,
                sender_id = senderId,
                created_at = sent,
                read_at = read
            };
        }

        public async Task<List<Messages>> GetMessagesBetweenUsers(FirestoreDb database, string userOneEmail, string userTwoEmail)
        {
            string userOneId = await FindUserIdByEmail(database, userOneEmail);
            string userTwoId = await FindUserIdByEmail(database, userTwoEmail);
            if (userOneId == null || userTwoId == null)
            {
                MessageBox.Show("One or both users not found.");
                return new List<Messages>();  // Return an empty list if either user is not found
            }

            List<Messages> messages = new List<Messages>();

            // Fetch messages where userOne is the sender and userTwo is the recipient
            CollectionReference messagesCollection = database.Collection("messages");
            Query queryOne = messagesCollection
                .WhereEqualTo("sender_id", userOneId)
                .WhereEqualTo("recipient_id", userTwoId);
            QuerySnapshot snapshotOne = await queryOne.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshotOne.Documents)
            {
                messages.Add(document.ConvertTo<Messages>());
            }

            // Fetch messages where userOne is the recipient and userTwo is the sender
            Query queryTwo = messagesCollection
                .WhereEqualTo("sender_id", userTwoId)
                .WhereEqualTo("recipient_id", userOneId);
            QuerySnapshot snapshotTwo = await queryTwo.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshotTwo.Documents)
            {
                messages.Add(document.ConvertTo<Messages>());
            }

            // Optionally, sort messages by created_at if needed
            messages.Sort((x, y) => DateTime.Compare(x.created_at, y.created_at));

            return messages;
        }



        // Display messages in the UI
        public async void DisplayMessagesBetweenUsers(string userOneEmail, string userTwoEmail)
        {
            FirestoreDb database = FirestoreHelper.Database;
            List<Messages> messages = await GetMessagesBetweenUsers(database, userOneEmail, userTwoEmail);

            foreach (Messages message in messages)
            {
                string prefix = message.sender_id == await FindUserIdByEmail(database, userOneEmail) ? "You sent: " : "Other sent: ";
                listBox1.Items.Add($"{prefix}{message.body} - Sent at: {message.created_at.ToLocalTime()}");
            }
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
                queryOne.Listen(snapshot => HandleDocumentChanges(snapshot, "You sent: ", messageDisplayBox));
                queryTwo.Listen(snapshot => HandleDocumentChanges(snapshot, "They sent: ", messageDisplayBox));
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