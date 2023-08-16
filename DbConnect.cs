using System.Data.SqlClient;

namespace EmployeeUI
{
    class DbConnect
    {
        public SqlConnection Connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=server;Initial Catalog=EmployeeDB;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
