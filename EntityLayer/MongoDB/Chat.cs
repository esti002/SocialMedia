using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.MongoDB
{
    public class Chat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string ContentText { get; set; }
        public string MediaPath { get; set; }
        public DateTime Date { get; set; }
    }
}
