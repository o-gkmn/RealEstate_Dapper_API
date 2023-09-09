using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet("bottom_grid_list")]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
    }
}
