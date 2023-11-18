using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace курсовая.classes
{
    public class TargetFilters
    {
        public int? AgeTo { get; set; }
        public int? AgeFrom { get; set; }
        public string Gender { get; set; }
        public string Region { get; set; }
        public string Diseases { get; set; }
        public string DisabilityLevel { get; set; }
        public string Allergies { get; set; }
    }

    class Notification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }

        [BsonElement("TargetFilters")]
        public TargetFilters Filters { get; set; }

        public Notification(string Topic, string Content, TargetFilters Filters)
        {
            this._id = new ObjectId();
            this.Topic = Topic;
            this.Content = Content;
            this.Filters = Filters;
        }
    }
}