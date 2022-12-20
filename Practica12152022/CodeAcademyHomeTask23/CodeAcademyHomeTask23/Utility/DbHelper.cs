
using System.Data.SqlClient;

namespace CodeAcademyHomeTask23.Utility;

public class DbHelper
{

    public SqlConnection GetSqlConnection()
    {
        string connectionString = @"Server=B3-10; Database = VDB;Trusted_Conection = True";
        using(SqlConnection connection = new SqlConnection(connectionString))
        {

            connection.Open();
            

        }
        return null;
    }
}
