using Microsoft.Data.SqlClient;
using Dapper;

namespace CogswellServiceAPI.DbAccess
{
    public class DbConnect
    {
        public static string connectionString = "Data Source=Joepez\\SQLEXPRESS;Initial Catalog=inventory;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection connection = new SqlConnection(connectionString);




    }
}
