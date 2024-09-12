using API_MVC.Contexts;

namespace API_MVC.Repositories.Interfaces
{
    public interface ICadAnimalRepository : IMongoDBContext<Models.CadAnimal>
    {
    }
}
