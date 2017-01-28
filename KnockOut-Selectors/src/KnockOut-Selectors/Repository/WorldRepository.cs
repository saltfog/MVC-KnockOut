using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnockOutSelectors.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;

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
            return Connection.Query<World>("select distinct cy.continent AS Continent, cy.name AS Country, co.name AS City from country cy join city co on co.countrycode = cy.code order by cy.continent, cy.name, co.name ASC");
        }
    }

}
