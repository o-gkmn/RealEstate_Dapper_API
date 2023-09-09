using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet("popular_locations")]
        public async Task<IActionResult> GetListPopularLocation()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}
