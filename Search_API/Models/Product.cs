using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Search_API.Models
{
    public class Product
    {
        [BsonId]  // ใช้แทน Primary Key
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 
        public string Name { get; set; } 
        public decimal Price { get; set; }
    }
}
