using GraphQLMongoDB.Domain.Base;

namespace GraphQLMongoDB.Domain
{
    public class Book : Document
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}
