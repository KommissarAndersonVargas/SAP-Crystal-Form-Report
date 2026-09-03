using Dapper;
using SAPCrystalReports.BaseClasses.BO;
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

        public static bool InsertNewUser(User user)
        {
            using (var connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                int rowsAffected = connection.Execute(DatabaseManager.InsertUsersQuery, new
                {
                    user.Name,
                    user.Login,
                    user.Password
                });

                return rowsAffected > 0;
            }
        }
    }
}
