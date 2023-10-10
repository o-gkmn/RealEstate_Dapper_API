using Dapper;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context = context;
        }

        public int CategoryCount()
        {
            string query = "SELECT Count(*) FROM Category";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ActiveCategoryCount()
        {
            string query = "SELECT Count(*) FROM Category WHERE CategoryStatus=1";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }

        public int ApartmentCount()
        {
            string query = "SELECT Count(*) FROM Product WHERE Title like '%Daire%'";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public string EmployeeNameBuyMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public string CategoryNameBuyMaxProductCount()
        {
            string query = "SELECT top(1) CategoryName, Count(*) FROM Product INNER JOIN Category ON " +
                "Product.ProductCategory=Category.CategoryID GROUP BY CategoryName ORDER BY Count(*) DESC";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "SELECT Avg(Price) FROM Product WHERE Type='Kiralık'";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<decimal>(query);
            return values;
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "SELECT Avg(Price) FROM Product WHERE Type='Satılık'";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<decimal>(query);
            return values;
        }

        public string CityNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public int DifferentCityCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int AverageRoomCount()
        {
            string query = "SELECT Avg(RoomCount) FROM ProductDetails";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ActiveEmployeeCount()
        {
            string query = "SELECT Count(*) FROM Employee WHERE Status=1";

            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }
    }
}
