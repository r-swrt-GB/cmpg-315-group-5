using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        /*
        public string title;
        public string description;
        public DateTime creationDate;
        public string createdBy;
        */
        public BackEndTest()
        {
            InitializeComponent();
            FirestoreDb database = FirestoreHelper.Database;
            //This must be the login email
            string recipientEmail = "receiver@example.com";
            string senderEmail = "sender@example.com";
            string groupTitle = "Group_Example_1";
            SetupRealTimeMessageListener(database, senderEmail, recipientEmail, listBox1);
            SetupRealTimeGroupMessageListener(database, groupTitle);
            //DisplayMessagesBetweenUsers(senderEmail, recipientEmail);
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

        public async Task SendMessageAsync(FirestoreDb database, string senderEmail, string recipientEmail, string messageBody, string groupTitle = null)
        {
            //Ensure email receiver and sender exists
            string senderId = await FindUserIdByEmail(database, senderEmail);
            string recipientId = null;

            if(groupTitle == null)
            {
                recipientId = await FindUserIdByEmail(database, recipientEmail);
            }

            if (recipientId == null && groupTitle == null)
            {
                MessageBox.Show("Recipient not found.");
                return;
            }

            //Create message
            Messages newMessage = new Messages()
            {
                body = messageBody,
                created_at = DateTime.UtcNow,//UtcNwo used for FireStore requirement
                sender_id = senderId,
                read_at = null  //message hasn't been read 

            };

            if (groupTitle != null)
            {
                newMessage.group_id = await FindGroupIdByTitle(database, groupTitle);
            }
            else
            {
                newMessage.recipient_id = recipientId;
            }

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
            string messageBody = "The quick brown fox jumps over the lazy dog";

            await SendMessageAsync(database, senderEmail, recipientEmail, messageBody);
        }

        //Not being used
        /*public Messages CreateMessage(string body, string groupId, string recipientId, string senderId, DateTime sent, DateTime? read = null)
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
        }*/

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

            // sort messages by created_at
            //messages.Sort((x, y) => DateTime.Compare(x.created_at, y.created_at));

            return messages;
        }



        // Display messages in the UI
        //Doesn't fix sorting issue, just displays messages again
        /*public async void DisplayMessagesBetweenUsers(string userOneEmail, string userTwoEmail)
        {
            FirestoreDb database = FirestoreHelper.Database;
            List<Messages> messages = await GetMessagesBetweenUsers(database, userOneEmail, userTwoEmail);

            foreach (Messages message in messages)
            {
                string prefix = message.sender_id == await FindUserIdByEmail(database, userOneEmail) ? "You sent: " : "Other sent: ";
                listBox1.Items.Add($"{prefix}{message.body} - Sent at: {message.created_at.ToLocalTime()}");
            }
        }*/


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

        // creates the group and writes it to the database
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

        // gets the group members from firebase
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

        // checks to see if the group the user wants to create already exists
        public bool ifGroupExist(string title)
        {
            var database = FirestoreHelper.Database;

            DocumentReference documentReference = database.Collection("groups").Document(title);
            Group name = documentReference.GetSnapshotAsync().Result.ConvertTo<Group>();

            if (name != null)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BackEndTest_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //when the form loads, the combobox and checkedlistboxes are populated
        private async void BackEndTest_Load(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;

            
            List<User> users = await GetAllUsers(database);

            PopulateCheckboxList(users);
            populateCombobox();
        }

        private async void button3_Click_1(object sender, EventArgs e)
        {
            string title = "Group_Example_2";
            string description = "This is a test to see if the code works";
            string created_by = "sender@example.com";
            DateTime created_at = DateTime.UtcNow; // converts to firebase readable format

            // which checkedlist box must be used
            CheckedListBox selectedListBox = getSelectedChecklistBox(checkedListBox2);

            await CreateGroup(selectedListBox, created_by, description, created_at, title);

            populateCombobox();
        }

        // Get the group names from the database
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

        // populates the combobox with the group names
        public async void populateCombobox()
        {
            FirestoreDb database = FirestoreHelper.Database;

            comboBox1.Items.Clear();
            List<string> names = await getGroupNames(database);

            comboBox1.Items.AddRange(names.ToArray());

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        public async Task addNewUsers(string title, List<string> newUsers)
        {
            try
            {
                var database = FirestoreHelper.Database;
                // Query for the group by title
                Query groupQuery = database.Collection("groups").WhereEqualTo("title", title);
                QuerySnapshot groupSnapshot = await groupQuery.GetSnapshotAsync();

                if (groupSnapshot.Count == 0)
                {
                    MessageBox.Show($"Group with the title '{title}' not found.");
                    return;
                }

                DocumentSnapshot groupDocument = groupSnapshot.Documents[0]; // This only works if group names are unique since it will stop at the first one
                List<string> existingUsers = groupDocument.GetValue<List<string>>("participants") ?? new List<string>();

                // Combine existing participants with new users and remove duplicates
                List<string> updatedUsers = existingUsers.Union(newUsers).ToList();

                // Update the group document with the new list of participants
                Dictionary<string, object> updates = new Dictionary<string, object>
                {
                    { "participants", updatedUsers }
                };
                await groupDocument.Reference.UpdateAsync(updates);

                MessageBox.Show($"{newUsers.Count} new users have been added to the group '{title}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add new users: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<string> selectedMembers = GetGroupMembers(checkedListBox1);

            string selectedGroup = comboBox1.SelectedItem.ToString();

            await addNewUsers(selectedGroup, selectedMembers);

            MessageBox.Show("new members added successfully!");
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

        // Send message to goup
        private async void button4_Click(object sender, EventArgs e)
        {
            FirestoreDb database = FirestoreHelper.Database;
            string senderEmail = "sender@example.com";
            string groupTitle = "Group_Example_1";
            string messageBody = "Test for group messages";

            await SendMessageAsync(database, senderEmail, null, messageBody, groupTitle);
        }

         public async Task<List<Messages>> GetMessagesForGroupById(FirestoreDb database, string group_id)
         {
             List<Messages> messages = new List<Messages>();

             CollectionReference messagesCollection = database.Collection("messages");
             Query query = messagesCollection.WhereEqualTo("group_id", group_id);
             QuerySnapshot snapshot = await query.GetSnapshotAsync();

             foreach (DocumentSnapshot document in snapshot.Documents)
             {
                 messages.Add(document.ConvertTo<Messages>());
             }

             return messages;
         }

        public async Task SetupRealTimeGroupMessageListener(FirestoreDb database, string groupTitle)
        {
            await Task.Run(async () =>
            {
                // Get the group ID using the group name
                string groupId = await FindGroupIdByTitle(database, groupTitle);

                if (groupId != null)
                {
                    CollectionReference messagesCollection = database.Collection("messages");

                    // Retrieve existing messages for the group
                    List<Messages> existingMessages = await GetMessagesForGroupById(database, groupId);

                    // Display existing messages in listBox2
                    foreach (Messages message in existingMessages)
                    {
                        string senderEmail = await FindUserIdByEmail(database, message.sender_id);
                        this.Invoke(new Action(() =>
                        {
                            listBox2.Items.Add($"Group: {groupTitle} | {senderEmail}: {message.body} - Sent at: {message.created_at.ToLocalTime()}");
                        }));
                    }

                    // Setup listener for real-time updates in the specified group
                    Query query = messagesCollection.WhereEqualTo("group_id", groupId);
                    query.Listen(async snapshot =>  // Marking this lambda as async
                    {
                        foreach (DocumentChange change in snapshot.Changes)
                        {
                            if (change.ChangeType == DocumentChange.Type.Added)
                            {
                                Messages message = change.Document.ConvertTo<Messages>();
                                string senderEmail = await FindUserIdByEmail(database, message.sender_id);
                                this.Invoke(new Action(() =>
                                {
                                    listBox2.Items.Add($"Group: {groupTitle} | {senderEmail}: {message.body} - Sent at: {message.created_at.ToLocalTime()}");
                                }));
                            }
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Group not found.");
                }
            });
        }

    }

}