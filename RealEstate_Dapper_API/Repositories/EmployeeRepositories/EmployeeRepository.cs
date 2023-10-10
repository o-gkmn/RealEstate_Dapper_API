using Dapper;
using RealEstate_Dapper_API.Dtos.EmployeeDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var properties = createEmployeeDto.GetType().GetProperties().ToList();

            string query = "insert into Employee (Name, Title, Mail, PhoneNumber, ImageUrl, Status) " +
                "values (@name, @title, @mail, @phonenumber, @imageurl, @status)";
            var parameters = new DynamicParameters();

            foreach (var item in properties)
            {
                var sqlVar = "@" + item.Name.ToLowerInvariant();
                parameters.Add(sqlVar, item.GetValue(createEmployeeDto));
            }

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);

        }

        public async void DeleteEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE EmployeeID=@employeeid";

            var parameters = new DynamicParameters();
            parameters.Add("@employeeid", id);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "SELECT * FROM Employee";

            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultEmployeeDto>(query);
            return values.ToList();
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "SELECT * FROM Employee WHERE EmployeeID=@employeeid";
            var parameters = new DynamicParameters();

            parameters.Add("@employeeid", id);

            using var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
            return values;
        }

        public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            var properties = updateEmployeeDto.GetType().GetProperties().ToList();
            var parameters = new DynamicParameters();

            var query = "Update Employee Set Name=@name, Title=@title, Mail=@mail, PhoneNumber=@phonenumber, " +
                "ImageUrl=@imageurl, Status=@status where EmployeeID=@employeeid";

            foreach (var item in properties)
            {
                var sqlVar = "@" + item.Name.ToLowerInvariant();
                parameters.Add(sqlVar, item.GetValue(updateEmployeeDto));
            }

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
    }
}