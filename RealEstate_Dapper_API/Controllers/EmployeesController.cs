using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.EmployeeDtos;
using RealEstate_Dapper_API.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("employees")]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }

        [HttpPost("add_employee")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Personel başarılı bir şekilde eklendi");
        }

        [HttpDelete("delete_employee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Personel başarılı bir şekilde silindi.");
        }

        [HttpPut("update_employee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Personel başarılı bir şekilde düzenlendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _employeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}
