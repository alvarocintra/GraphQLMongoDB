using GraphQLMongoDB.Data.Repository;
using GraphQLMongoDB.Domain;
using HotChocolate;
using HotChocolate.Subscriptions;
using System.Threading.Tasks;

namespace GraphQLMongoDB.Data.GraphQL
{
    public class Mutation
    {
        public async Task<Book> CreateBook(
            [Service] IMongoRepository<Book> repository, 
            [Service] ITopicEventSender eventSender, 
            Book inputBook)
        {
            repository.InsertOne(inputBook);

            await eventSender.SendAsync("BookCreated", inputBook);

            return inputBook;
        }

        public async Task<Author> CreateAuthor(
            [Service] IMongoRepository<Author> repository,
            [Service] ITopicEventSender eventSender, 
            string name)
        {
            var author = new Author
            {
                Name = name
            };

            repository.InsertOne(author);

            await eventSender.SendAsync("AuthorCreated", author);

            return author;
        }
    }
}
