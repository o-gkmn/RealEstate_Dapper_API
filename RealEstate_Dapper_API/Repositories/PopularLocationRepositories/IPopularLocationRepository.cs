using RealEstate_Dapper_UI.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_UI.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetPopularLocationDto> GetPopularLocation(int id);
    }
}
