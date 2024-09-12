using API_MVC.Contexts;
using API_MVC.Repositories.Interfaces;

namespace API_MVC.Repositories.Implementations
{
    public class CadAnimalRepository() : MongoDBContext<Models.CadAnimal>, ICadAnimalRepository
    {
    }
}
