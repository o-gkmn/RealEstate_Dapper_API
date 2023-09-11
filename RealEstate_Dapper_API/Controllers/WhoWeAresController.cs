using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAresController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAresController(IWhoWeAreRepository WhoWeAreRepository)
        {
            _whoWeAreRepository = WhoWeAreRepository;
        }

        [HttpGet("who_we_ares")]
        public async Task<IActionResult> WhoWeAreList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreAsync();
            return Ok(values);
        }

        [HttpPost("add_WhoWeAre")]
        public async Task<IActionResult> CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto)
        {
            _whoWeAreRepository.CreateWhoWeAre(createWhoWeAreDto);
            return Ok("Hakkımızda kısmı başarılı bir şekilde eklendi");
        }

        [HttpDelete("delete_WhoWeAre")]
        public async Task<IActionResult> DeleteWhoWeAre(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAre(id);
            return Ok("Hakkımızda kısmı başarılı bir şekilde silindi.");
        }

        [HttpPut("update_WhoWeAre")]
        public async Task<IActionResult> UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            _whoWeAreRepository.UpdateWhoWeAre(updateWhoWeAreDto);
            return Ok("Hakkımızda kısmı başarılı bir şekilde düzenlendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAre(int id)
        {
            var value = await _whoWeAreRepository.GetWhoWeAre(id);
            return Ok(value);
        }
    }
}
