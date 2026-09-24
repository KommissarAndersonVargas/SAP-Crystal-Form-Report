using System;

namespace SAPCrystalReports.Classes
{
    public class EmployeeData
    {
        public EmployeeData( string first_Name, string last_Name, DateTime date_of_Birth, Decimal income, string cell_Phone_Number, string email)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Date_of_Birth = date_of_Birth;
            Income = income;
            Cell_Phone_Number = cell_Phone_Number;
            Email = email;
        }

        public EmployeeData() { }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public Decimal Income { get; set; }
        public string Cell_Phone_Number { get; set; }
        public string Email { get; set; }
    }
}
