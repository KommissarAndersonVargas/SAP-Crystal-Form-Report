using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Data.SqlClient;
using SAPCrystalReports.Classes;
using Dapper;

namespace Base_Classes
{
    public class EmployeeDAO
    {
        public static bool AddNewEmployee(EmployeeData employee)
        {
            using (var connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                int rowsAffected = connection.Execute(DatabaseManager.InsertEmployeDataQuery, new
                {
                    employee.First_Name,
                    employee.Last_Name,
                    employee.Date_of_Birth,
                    employee.Income,
                    employee.Cell_Phone_Number,
                    employee.Email
                });

                return rowsAffected > 0;
            }
        }

    }
}
