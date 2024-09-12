namespace API_MVC.Contexts
{
    public interface IMongoDBContext <TModel>
    {
        Task<List<TModel>> GetAsync(CancellationToken cancellationToken);
        Task<TModel> GetAsync(Guid id, CancellationToken cancellationToken);
        Task InsertAsync(TModel model, CancellationToken cancellationToken);
        Task UpdateAsync(TModel model, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);

    }
}
