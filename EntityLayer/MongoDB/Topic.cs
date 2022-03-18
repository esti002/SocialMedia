using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.MongoDB
{
    public class Topic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int LastPops { get; set; }//son 1 gundeki populerligine bakilacak(son gunde atilan toplam mesaj sayisi)->proje ilerledikce populerlik icin iyilestirme yapilacak
        public string TitleName { get; set; }
        public int TitleOwner { get; set; }
        public DateTime Date { get; set; }
    }
}
