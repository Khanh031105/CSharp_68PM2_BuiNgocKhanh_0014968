using Microsoft.Data.SqlClient;

namespace QLSV
{
    public class Database
    {
        private string connectionString =
            @"Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}