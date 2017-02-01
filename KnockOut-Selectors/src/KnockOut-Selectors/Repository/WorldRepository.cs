using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using KnockOutSelectors.Models;
using System.Linq;

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
            var list = Connection.Query<World>("select * from country limit 30");
            return list;
        }
    }

}
