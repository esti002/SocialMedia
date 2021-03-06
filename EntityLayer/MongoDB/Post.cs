using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.MongoDB
{
    public  class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int PostOwner { get; set; }
        public int AccessToken { get; set; }
        public string ContentText { get; set; }
        public string MediaPath { get; set; }
        public DateTime Date { get; set; }
        public int TopicId { get; set; }
    }
}
