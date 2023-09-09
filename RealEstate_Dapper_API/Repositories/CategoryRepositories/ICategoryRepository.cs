using RealEstate_Dapper_UI.Dtos.CategoryDtos;
using RealEstate_Dapper_UI.Dtos.CategoryDtos;

namespace RealEstate_Dapper_UI.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto createCategoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
