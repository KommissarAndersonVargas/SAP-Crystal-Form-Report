using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPCrystalReports.Classes
{
    public class UserBuilder
    {
        private readonly UserData data;

        public UserBuilder()
        {
            this.data = new UserData();
        }

        public UserBuilder Id(string id)
        {
            data.Id = id;
            return this; 
        }
        public UserBuilder FirstName(string firstName)
        {
            data.First_Name = firstName;
            return this;
        }

        public UserBuilder LastName(string lastName)
        {
            data.Last_Name = lastName;
            return this;
        }
        public UserBuilder DateOfBirth(string dateOfBirth)
        {
            data.Date_of_Birth = dateOfBirth;
            return this;
        }

        public UserBuilder Income(string income)
        {
            data.Income = income;
            return this;
        }

        public UserBuilder CellPhoneNumber(string cellNumber)
        {
            data.Cell_Phone_Number = cellNumber;
            return this;
        }

        public UserBuilder Email(string email)
        {
            data.Email = email;
            return this;
        }

        public UserData CreateUserData()
        {
            return data;
        }
    }
}
