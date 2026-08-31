using Dapper;
using SAPCrystalReports.BaseClasses.DTOs;
using SDatabaseContexts;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SAPCrystalReports.BaseClasses.BO
{
    public class UserBO
    {
        public static bool ValidadeUser(string login, string password)
        {
            var users = UsersDAO.GetUsers();
            var validateUserResult = users.Any(user => user.Password.Trim().Equals(password) && user.Login.Trim().Equals(login));

            return validateUserResult;
        }

        public static List<User> GetUsers()
        {
            return UsersDAO.GetUsers().ToList();
        }
    }
}
