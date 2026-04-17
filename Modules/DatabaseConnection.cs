using Microsoft.Data.SqlClient;

namespace BAMS.Modules
{
    public class DatabaseConnection
    {
        private static string connectionString =
        "Server=Your_SERVER;Database=Your_DATABASE;User Id=Your_USER;Password=Your_PASSWORD;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}