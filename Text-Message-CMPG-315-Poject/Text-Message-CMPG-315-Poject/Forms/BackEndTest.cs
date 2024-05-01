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

namespace Text_Message_CMPG_315_Poject.Forms
{
    public partial class BackEndTest : Form
    {
        public BackEndTest()
        {
            InitializeComponent();
        }

        public async Task<string> FindUserIdByEmail(FirestoreDb database, string email)
        {
            CollectionReference usersCollection = database.Collection("users");
            Query query = usersCollection.WhereEqualTo("Email", email);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Count == 1)
            {
                DocumentSnapshot userDocument = snapshot.Documents[0];
                return userDocument.Id;
            }
            return null;
        }

        public async Task SendMessageAsync(FirestoreDb database, string senderEmail, string recipientEmail, string messageBody)
        {
            string senderId = await FindUserIdByEmail(database, senderEmail);
            string recipientId = await FindUserIdByEmail(database, recipientEmail);

            if (recipientId == null)
            {
                MessageBox.Show("Recipient not found.");
                return;
            }

            Messages newMessage = new Messages()
            {
                body = messageBody,
                created_at = DateTime.UtcNow,
                recipient_id = recipientId,
                sender_id = senderId,
                read_at = null  //message hasn't been read 
            };

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

    }
}
