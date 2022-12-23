using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Data
{
	public class MsqlConfig

	{
        
            private readonly string _connectionString;

            public MsqlConfig(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("MySqlConnection");
            }
            public IDbConnection Connection => new MySqlConnection(_connectionString);
        }

    
}
