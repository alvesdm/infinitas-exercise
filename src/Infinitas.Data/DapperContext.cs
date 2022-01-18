using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Infinitas.Data
{
    public class DapperContext : IAmDbContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
    }
}
