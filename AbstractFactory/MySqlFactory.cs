using System.Data;

namespace AbstractFactory
{
    public class MySqlFactory : IDbFactory
    {
        public IDbConnection CreateDbConnection()
        {
            return new MySql.Data.MySqlClient.MySqlConnection();
        }

        public IDbCommand CreateDbCommand()
        {
            return new MySql.Data.MySqlClient.MySqlCommand();
        }

        public IDbDataParameter CreateDbDataParameter()
        {
            return new MySql.Data.MySqlClient.MySqlParameter();
        }
    }
}