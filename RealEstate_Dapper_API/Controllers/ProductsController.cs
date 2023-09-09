using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Repositories.ProductRepositories;

namespace RealEstate_Dapper_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("products")]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("products_with_category")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
    }
}
