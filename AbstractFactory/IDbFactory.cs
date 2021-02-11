using System.Data;

namespace AbstractFactory
{
    public interface IDbFactory
    {
        IDbConnection CreateDbConnection();

        IDbCommand CreateDbCommand();

        IDbDataParameter CreateDbDataParameter();
    }
}