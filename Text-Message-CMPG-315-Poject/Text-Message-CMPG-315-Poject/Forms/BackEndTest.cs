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
            SetupRealTimeMessageListener(database, recipientEmail);
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

        public async Task<List<Messages>> GetMessagesForRecipient(FirestoreDb database, string recipientEmail)
        {
            string recipientId = await FindUserIdByEmail(database, recipientEmail);
            if (recipientId == null)
            {
                MessageBox.Show("Recipient not found.");
                return new List<Messages>();  // Return an empty list if no recipient is found
            }

            // Fetch messages for the recipient_id 
            CollectionReference messagesCollection = database.Collection("messages");
            Query query = messagesCollection.WhereEqualTo("recipient_id", recipientId);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            List<Messages> messages = new List<Messages>();
            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                Messages message = documentSnapshot.ConvertTo<Messages>();
                messages.Add(message);
            }

            return messages;
        }

        // Display messages in the UI
        public async void DisplayMessages(string recipientEmail)
        {
            FirestoreDb database = FirestoreHelper.Database;
            List<Messages> messages = await GetMessagesForRecipient(database, recipientEmail);

            foreach (Messages message in messages)
            {
                listBox1.Items.Add(message.body + " - Sent at: " + message.created_at.ToString());
            }
        }

        public void SetupRealTimeMessageListener(FirestoreDb database, string recipientEmail)
        {
            Task.Run(async () =>
            {
                string recipientId = await FindUserIdByEmail(database, recipientEmail);
                if (recipientId == null)
                {
                    MessageBox.Show("Recipient not found.");
                    return;
                }

                CollectionReference messagesCollection = database.Collection("messages");
                Query query = messagesCollection.WhereEqualTo("recipient_id", recipientId);

                // Listen for real-time updates
                FirestoreChangeListener listener = query.Listen(snapshot =>
                {
                    foreach (DocumentChange change in snapshot.Changes)
                    {
                        if (change.ChangeType == DocumentChange.Type.Added)
                        {
                            Messages message = change.Document.ConvertTo<Messages>();
                            this.Invoke(new Action(() =>
                            {
                                listBox1.Items.Add($"{message.body} - Sent at: {message.created_at.ToString()}");
                            }));
                        }
                    }
                });
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
