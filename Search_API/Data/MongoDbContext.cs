using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Search_API.Models;
using Search_API.Settings;

namespace Search_API.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDbSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _database = client.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<Product> Products =>
            _database.GetCollection<Product>("Products");

        //public IMongoCollection<Category> Categories =>
        //    _database.GetCollection<Category>("Categories");
    }
}
