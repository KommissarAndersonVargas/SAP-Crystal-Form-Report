using Dapper;
using SAPCrystalReports.BaseClasses.DTOs;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SDatabaseContexts
{
    internal class UsersDAO
    {
        public static IEnumerable<User> GetUsers()
        {
            using (var connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                return connection.Query<User>(DatabaseManager.SelectUsers);
            }
        }
    }
}
