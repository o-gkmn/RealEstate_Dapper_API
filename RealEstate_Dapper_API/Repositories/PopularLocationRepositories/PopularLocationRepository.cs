using Dapper;
using RealEstate_Dapper_UI.Dtos.PopularLocationDtos;
using RealEstate_Dapper_UI.Models.DapperContext;

namespace RealEstate_Dapper_UI.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "SELECT * FROM PopularLocation";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public Task<GetPopularLocationDto> GetPopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
