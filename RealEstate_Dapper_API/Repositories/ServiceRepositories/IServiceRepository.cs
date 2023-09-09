using RealEstate_Dapper_UI.Dtos.ServiceDtos;

namespace RealEstate_Dapper_UI.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
