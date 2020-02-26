using System.Configuration;
using System.Data.SqlClient;

namespace OnlineShoppingSystem_DAL
{
    public class Connection
    {
        public static SqlConnection Connected()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
