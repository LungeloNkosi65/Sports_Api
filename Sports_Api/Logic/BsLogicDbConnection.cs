using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Logic
{
    public class BsLogicDbConnection
    {
        private static readonly string connectionString = "Server=(LocalDb)\\LocalDb;Database=HollywoodBetsRepDb;Trusted_Connection=True;";
        public static SqlConnection SqlConnection()
        {
            var connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
