using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_CMPG315.Classes
{
    [FirestoreData]
    public class Groups
    {
        [FirestoreProperty]
        public DateTime created_at { get; set; }

        [FirestoreProperty]
        public string created_by { get; set; }

        [FirestoreProperty]
        public string description { get; set; }

        [FirestoreProperty]
        public List<string> participants { get; set; }

        [FirestoreProperty]
        public string title { get; set; }

    }
}
