using MongoDB.Bson.Serialization.Attributes;

namespace API_CRUD_MongoDB.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id {get;set;}

        public string Name {get;set;} = null!;
        public decimal Price {get;set;}
        public int Stock {get;set;}
    }
}