using RealEstate_Dapper_API.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
