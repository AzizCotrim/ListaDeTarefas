using Microsoft.Data.SqlClient;

namespace ListaDeTarefas.Infrastructure.Database
{
    public sealed class DataBase
    {
        private readonly string _conn;

        public DataBase(string conn)
        {
            _conn = conn;
        }

        public SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(_conn);

            return conn;
        }

    }
}