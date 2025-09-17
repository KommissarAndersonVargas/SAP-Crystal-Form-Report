using System.Data.SqlClient;

public static class DatabaseConnection
{
    private static string connectionString = @"Data Source=DESKTOP-H0IIS6S\SQL2014;
                  Initial Catalog=My_Staff;
                  Persist Security Info=True;
                  User ID=sa;
                  Password=123456;
                  TrustServerCertificate=True";

    // Comando INSERT com parâmetros
    public static string insertQuery = @"
                INSERT INTO [My_Staff].[dbo].[Imp_Info]
                (First_Name, Last_Name, Date_of_birth, income, Cell_Number, Email)
                VALUES
                (@FirstName, @LastName, @DateOfBirth, @Income, @CellNumber, @Email);
            ";


    public static string GetConnection()
    {
        return connectionString;
    }
}