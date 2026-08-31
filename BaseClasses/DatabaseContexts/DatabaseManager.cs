using System.Data.SqlClient;

public static class DatabaseManager
{
    private static string _connectionString = @"Data Source=DESKTOP-H0IIS6S\SQL2014;
                  Initial Catalog=My_Staff;
                  Persist Security Info=True;
                  User ID=sa;
                  Password=123456;
                  TrustServerCertificate=True";

    // Comando INSERT Funcionários
    private static string _insertEmployeDataQuery = @"
    INSERT INTO Imp_Info (First_Name, Last_Name, Date_of_birth, Income, Cell_Number, Email)
    VALUES (@First_Name, @Last_Name, @Date_Of_Birth, @Income, @Cell_Phone_Number, @Email)";

    //Comando Select users
    private static string _selectUsers =  @"SELECT * FROM User_Table";


    public static string ConnectionString
    {
        get
        {
            return _connectionString;
        }
    }

    public static string SelectUsers
    {
        get
        {
            return _selectUsers;
        }
    }

    public static string InsertEmployeDataQuery
    {
        get
        {
            return _insertEmployeDataQuery;
        }
    }
}