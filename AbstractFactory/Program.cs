using System.Data;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDbFactory factory;

            if ("sql" == args[0])
            {
                factory = new SqlFactory();
            }
            else
            {
                factory = new MySqlFactory();
            }

            using (var connection = factory.CreateDbConnection())
            {
                connection.Open();
                var command = factory.CreateDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Users] WHERE [UserId] = ?";
                var param = factory.CreateDbDataParameter();
                param.DbType = DbType.Int32;
                param.Value = 42;
                command.Parameters.Add(param);

                command.ExecuteReader();
            }
        }
    }
}