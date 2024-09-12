using API_MVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MVC.Controllers.CadAnimal
{
    [Route("api/cad-animal")]
    public class HomeController(ICadAnimalRepository cadAnimalRepository) : ControllerBase
    {
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken) 
            => Ok(await cadAnimalRepository.GetAsync(cancellationToken));
    }
}
