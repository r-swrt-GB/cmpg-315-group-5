using Google.Cloud.Firestore;
using System;

namespace ChatApp_CMPG315.Classes
{
    [FirestoreData]
    public class Messages
    {

        [FirestoreProperty]
        public string body { get; set; }

        [FirestoreProperty]
        public DateTime created_at { get; set; }

        [FirestoreProperty]
        public string recipient_id { get; set; }

        [FirestoreProperty]
        public string sender_id { get; set; }

    }
}

