using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Sports_Api.Services
{
    public class DatabaseService
    {
        private static readonly string ConnectionString = "Server=(LocalDb)\\LocalDBDemo;Database=HollywoodBetsRepDb;Trusted_Connection=True;";

        public static SqlConnection sqlConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            return connection;
        }
    }
}
