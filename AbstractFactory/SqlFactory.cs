using System.Data;

namespace AbstractFactory
{
    public class SqlFactory : IDbFactory
    {
        public IDbConnection CreateDbConnection()
        {
            return new System.Data.SqlClient.SqlConnection();
        }

        public IDbCommand CreateDbCommand()
        {
            return new System.Data.SqlClient.SqlCommand();
        }

        public IDbDataParameter CreateDbDataParameter()
        {
            return new System.Data.SqlClient.SqlParameter();
        }
    }
}