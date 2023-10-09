using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Repositories.CategoryRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost("add_category")]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpDelete("delete_category/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori başarılı bir şekilde silindi.");
        }

        [HttpPut("update_category")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok("Kategori başarılı bir şekilde düzenlendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoryRepository.GetCategory(id);
            return Ok(value);
        }
    }
}
