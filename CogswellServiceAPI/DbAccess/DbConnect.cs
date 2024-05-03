using Microsoft.Data.SqlClient;
using Dapper;

namespace CogswellServiceAPI.DbAccess
{
    public class DbConnect
    {
        public static string ConnectionString = "Data Source=Joepez\\SQLEXPRESS;Initial Catalog=inventory;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection Connection = new SqlConnection(ConnectionString);








    }
}
