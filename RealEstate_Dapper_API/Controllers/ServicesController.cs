using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Repositories.ServiceRepositories;

namespace RealEstate_Dapper_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet("get_service_list")]
        public async Task<IActionResult> GetServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }
    }
}
