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

namespace SAPCrystalReports.Base_Classes
{
    public class EmployeeDAO
    {
        public static bool AddNewEmployee(EmployeeData employee)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnection()))
            {
                using (SqlCommand cmd = new SqlCommand(DatabaseConnection.insertQuery, conn))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = employee.First_Name;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = employee.Last_Name;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = employee.Date_of_Birth;
                    cmd.Parameters.Add("@Income", SqlDbType.Decimal).Value = employee.Income;
                    cmd.Parameters.Add("@CellNumber", SqlDbType.VarChar, 50).Value = employee.Cell_Phone_Number;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = employee.Email;

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }
    }
}
