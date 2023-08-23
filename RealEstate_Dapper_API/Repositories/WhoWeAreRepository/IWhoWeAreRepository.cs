using RealEstate_Dapper_API.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDto>> GetAllWhoWeAreAsync();
        void CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto);
        void DeleteWhoWeAre(int id);
        void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto);
        Task<GetByIDWhoWeAreDto> GetWhoWeAre(int id);
    }
}
