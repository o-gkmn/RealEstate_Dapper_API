using Dapper;
using RealEstate_Dapper_API.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepositories
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto)
        {
            string query = "insert into WhoWeAre (Title, Subtitle, Description1, Description2) values (@title, @subtitle, @description1, @description2)";
            var parameters = new DynamicParameters();

            parameters.Add("@title", createWhoWeAreDto.Title);
            parameters.Add("@subtitle", createWhoWeAreDto.Subtitle);
            parameters.Add("@description1", createWhoWeAreDto.Description1);
            parameters.Add("@description2", createWhoWeAreDto.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAre(int id)
        {
            string query = "DELETE FROM WhoWeAre WHERE WhoWeAreID=@whoweareID";

            var parameters = new DynamicParameters();
            parameters.Add("@whoweareID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDto>> GetAllWhoWeAreAsync()
        {
            string query = "SELECT * FROM WhoWeAre";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDto> GetWhoWeAre(int id)
        {
            string query = "SELECT * FROM WhoWeAre WHERE WhoWeAreID=@whoweareID";
            var parameters = new DynamicParameters();

            parameters.Add("@whoweareID", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            var query = "Update WhoWeAre Set Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2 where WhoWeAreID=@whoweareID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoweareID", updateWhoWeAreDto.WhoWeAreID);
            parameters.Add("@title", updateWhoWeAreDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDto.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDto.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
