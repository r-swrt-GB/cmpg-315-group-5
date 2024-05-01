using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Message_CMPG_315_Poject.Classes
{
    [FirestoreData]
    public class Messages
    {
        // class created to fetch and send data to the server

        [FirestoreProperty]
        public string primkey { get; set; }

        [FirestoreProperty]
        public string body { get; set; }

        [FirestoreProperty]
        public DateTime created_at { get; set; }

        [FirestoreProperty]
        public string group_id { get; set; }

        [FirestoreProperty]
        public DateTime? read_at { get; set; } //add "?" to make nullable since message wont be read immediately

        [FirestoreProperty]
        public string recipient_id { get; set; }

        [FirestoreProperty]
        public string sender_id { get; set; }

    }
}
