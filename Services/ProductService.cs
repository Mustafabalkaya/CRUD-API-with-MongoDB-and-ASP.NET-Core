using API_CRUD_MongoDB.DTO;
using API_CRUD_MongoDB.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace API_CRUD_MongoDB.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;

        public ProductService(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _products = mongoDatabase.GetCollection<Product>(databaseSettings.Value.CollectionName);
        }

        public async Task<List<Product>> GetProducts() => 
        await _products.Find(product => true).ToListAsync();

        public async Task<Product> GetProductById(string id) =>
        await _products.Find(product=>product.Id == id).FirstOrDefaultAsync();

        public async Task<Product> CreateProduct(Product product)
        {
            await _products.InsertOneAsync(product);
            return product;
        }

        public async Task UpdateProduct(string id, ProductDTO productDTO)
        {
            var update = Builders<Product>.Update
            .Set(p=>p.Name, productDTO.Name)
            .Set(p=>p.Price, productDTO.Price)
            .Set(p=>p.Stock, productDTO.Stock);

            await _products.UpdateOneAsync(p=>p.Id == id, update);
        }

        public async Task DeleteProduct(string id)=>
        await _products.DeleteOneAsync(p=>p.Id==id);
    }
}