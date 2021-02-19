using GraphQLMongoDB.Data.Repository;
using GraphQLMongoDB.Domain;
using HotChocolate;
using System.Linq;

namespace GraphQLMongoDB.Data.GraphQL
{
    public class Query
    {
        //[UseFiltering]
        //[UseSorting]
        public IQueryable<Book> GetBook([Service] IMongoRepository<Book> repository) => repository.AsQueryable();

        //[UseFiltering]
        //[UseSorting]
        public IQueryable<Author> GetAuthor([Service] IMongoRepository<Author> repository) => repository.AsQueryable();

    }
}
