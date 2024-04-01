using System.Data.SQLite;

namespace BankingApp.Domain.DataBase
{
    public class SQLiteDB
    {
        private readonly string _connectionString;

        public SQLiteDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }
    }
}