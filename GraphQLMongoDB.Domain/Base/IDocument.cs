using System;

namespace GraphQLMongoDB.Domain.Base
{
    public interface IDocument
    {
        string Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
