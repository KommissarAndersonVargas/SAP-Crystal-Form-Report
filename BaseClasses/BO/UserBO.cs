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

        public static bool InsertNewUser(User user, string confirmPassword)
        {
            if (!user.Password.Equals(confirmPassword))
                return false;

            return UsersDAO.InsertNewUser(user);
        }

        public static List<User> GetUsers()
        {
            return UsersDAO.GetUsers().ToList();
        }
        public static bool IsValidUser(User user)
        {
            var users = UsersDAO.GetUsers();

            var isInvalidLogin = users.Any(_user => _user.Login.Trim() == user.Login);

            return isInvalidLogin;
        }
    }
}
