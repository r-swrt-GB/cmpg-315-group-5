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

        private void button1_Click(object sender, EventArgs e)
        {

            // dummy text that will be entered into the database
            string primkey;
            string body;
            string group;
            string recipient;
            string senderID;
            DateTime sent;
            DateTime read;

            // test data
            body = "This is a test message";
            group = null;
            recipient = "Stefan";
            senderID = "Tester";
            sent = DateTime.Now;
            read = DateTime.Now;
            primkey = recipient + sent.ToString();

            // connect to the database via the Messages collection
            var database = FirestoreHelper.Database;


            // add message variable object to be stored in the database
            var data = message(primkey,body, group, recipient, senderID, sent, read);

            // gets reference to the messages collection in the database (the reference is the body?)

            DocumentReference documentReference = database.Collection("messages").Document("1234");

            // write the data to the database
            documentReference.SetAsync(data);

            MessageBox.Show(data.primkey);

        }

       // function to create a new message object
        public Messages message(string primkey,string body, string group, string recipient, string sender, DateTime sent, DateTime read)
        {
            return new Messages()
            {
                primkey = primkey,
                body = body,
                group_id = group,
                recipient_id = recipient,
                sender_id = sender,
                created_at = sent,
                read_at = read,
                //im helping
            };
        }
    }
}
