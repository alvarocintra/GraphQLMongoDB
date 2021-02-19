using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GraphQLMongoDB.Domain.Base
{
    public abstract class Document : IDocument
    {
        protected Document()
        {
            CreatedDate = DateTime.UtcNow;
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
