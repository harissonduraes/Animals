using MongoDB.Bson.Serialization.Attributes;

namespace API_MVC.Models
{
    public class BaseModel
    {
        [BsonId]
        public Guid Id { get; set; }
    }
}
