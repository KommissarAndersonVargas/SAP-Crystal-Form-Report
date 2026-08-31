using Dapper;
using SAPCrystalReports.BaseClasses.DTOs;
using SAPCrystalReports.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
