using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Search_API.Settings;
using Search_API.Models;
using Search_API.Data;

namespace Search_API.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductService(MongoDbContext context)
        {
            _collection = context.Products;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() =>
        await _collection.Find(_ => true).ToListAsync();

        public async Task<Product?> GetByIdAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Product item) =>
            await _collection.InsertOneAsync(item);

        public async Task UpdateAsync(string id, Product updatedItem) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedItem);

        public async Task DeleteAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}
