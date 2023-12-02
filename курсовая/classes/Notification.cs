using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace курсовая.classes
{
    public class TargetFilters
    {
        public string AgeTo { get; set; }
        public string AgeFrom { get; set; }
        public string Gender { get; set; }
        public string Region { get; set; }
        public string Diseases { get; set; }
        public string DisabilityLevel { get; set; }
        public string Allergies { get; set; }

        public TargetFilters(string AgeTo, string AgeFrom, string Gender, string Region, string Diseases, string DisabilityLevel, string Allergies)
        {
            this.AgeTo = AgeTo;
            this.AgeFrom = AgeFrom;
            this.Gender = Gender;
            this.Region = Region;
            this.Diseases = Diseases;
            this.DisabilityLevel = DisabilityLevel;
            this.Allergies = Allergies;
        }
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