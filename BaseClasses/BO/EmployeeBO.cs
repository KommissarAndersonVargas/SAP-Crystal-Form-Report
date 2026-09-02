using Base_Classes;
using Microsoft.IdentityModel.Tokens;
using SAPCrystalReports.Classes;

namespace SAPCrystalReports.BaseClasses.BO
{
    public class EmployeeBO
    {
        public static bool AddNewEmployee(EmployeeData employee)
        {
            if (!IsValidObject(employee))
                return false;

            return EmployeeDAO.AddNewEmployee(employee);
        }
        private static bool IsValidObject(EmployeeData employee)
        {
            var isValid = employee.Cell_Phone_Number.IsNullOrEmpty() && employee.First_Name.IsNullOrEmpty()
                && employee.Last_Name.IsNullOrEmpty() && employee.Email.IsNullOrEmpty() &&  employee.Date_of_Birth != null;

            return isValid;
        }
    }
}
