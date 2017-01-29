using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using KnockOutSelectors.Models;

namespace KnockOutSelectors.Repository
{
    public class WorldRepository : IRepository
    {
        private string connectionString;
        public WorldRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public IEnumerable<World> GetWorld()
        {
            return Connection.Query<World>("select continent, country.name AS country, city.name AS city from country join city on country.code = city.countrycode");
        }
    }

}
