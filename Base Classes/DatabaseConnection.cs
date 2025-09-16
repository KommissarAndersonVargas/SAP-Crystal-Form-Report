using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString = "Data Source=DESKTOP-H0IIS6S\\SQL2014;Initial Catalog=My_Staff;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}