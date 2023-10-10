using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.StatisticRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public StatisticsController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("active_category_count")]
        public IActionResult ActiveCategoryCount() 
        { 
            return Ok(_statisticRepository.ActiveCategoryCount());
        }

        [HttpGet("active_employee_count")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticRepository.ActiveEmployeeCount());
        }

        [HttpGet("apartment_count")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticRepository.ApartmentCount());
        }

        [HttpGet("average_product_price_by_rent")]
        public IActionResult AverageProductPriceByRent()
        {
            return Ok(_statisticRepository.AverageProductPriceByRent());
        }

        [HttpGet("average_product_price_by_sale")]
        public IActionResult AverageProductPriceBySale()
        {
            return Ok(_statisticRepository.AverageProductPriceBySale());
        }

        [HttpGet("average_room_count")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticRepository.AverageRoomCount());
        }

        [HttpGet("category_count")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticRepository.CategoryCount());
        }

        [HttpGet("category_name_buy_max_product_count")]
        public IActionResult CategoryNameBuyMaxProductCount()
        {
            return Ok(_statisticRepository.CategoryNameBuyMaxProductCount());
        }
    }
}
