using GraphQLMongoDB.Domain.Base;

namespace GraphQLMongoDB.Domain
{
    public class Author : Document
    {
        public string Name { get; set; }
    }
}
