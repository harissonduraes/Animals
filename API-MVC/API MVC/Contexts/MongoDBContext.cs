using API_MVC.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace API_MVC.Contexts;

public abstract class MongoDBContext<TModel> : IMongoDBContext<TModel>
    where TModel : BaseModel
{
    public MongoDBContext()
    {
        MongoClient client = new("mongodb://localhost:27017");

        _database = client.GetDatabase("API_MVC");
    }

    private readonly IMongoDatabase _database;
    private IMongoCollection<TModel> Collection => _database.GetCollection<TModel>(typeof(TModel).Name);

    protected IMongoQueryable<TModel> Query => Collection.AsQueryable();

    public async Task<List<TModel>> GetAsync(CancellationToken cancellationToken) => 
        await Query.ToListAsync(cancellationToken);

    public async Task <TModel> GetAsync (Guid id, CancellationToken cancellationToken) => 
        await Query.SingleOrDefaultAsync(w => w.Id == id, cancellationToken);

    public async Task InsertAsync(TModel model, CancellationToken cancellationToken) =>
        await Collection.InsertOneAsync(model, cancellationToken: cancellationToken);

    public async Task UpdateAsync(TModel model, CancellationToken cancellationToken) =>
        await Collection.ReplaceOneAsync(w => w.Id == model.Id, model, cancellationToken: cancellationToken);

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken) =>
        await Collection.DeleteOneAsync(w => w.Id == id, cancellationToken: cancellationToken);

}
