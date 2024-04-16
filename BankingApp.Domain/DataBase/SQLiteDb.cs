using System.Data.SQLite;
using System.Text;

namespace BankingApp.Domain.DataBase
{
    public class SQLiteDB
    {
        private readonly string _dataBase;

        public SQLiteDB(string dataBase)
        {
            _dataBase = dataBase;
            
        }

        private void CreateDataBase()
        {
            SQLiteConnection.CreateFile(_dataBase);
            using(SQLiteConnection connectionString = new SQLiteConnection($"Data Source={_dataBase}; Version=3;"))
            {
                connectionString.Open();
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("CREATE TABLE IF NOT EXIST Users");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("Id INTEGER PRIMARY KEY AUTO INCREMENT,");
                stringBuilder.AppendLine("Name VARCHAR(55) NOT NULL,");
                stringBuilder.AppendLine("Email VARCHAR(150) NOT NULL,");
                stringBuilder.AppendLine("Password VARCHAR(20) NOT NULL,");
                stringBuilder.AppendLine("Name VARCHAR(55) NOT NULL,");
                stringBuilder.AppendLine("CPF VARCHAR(14) NOT NULL,");
                stringBuilder.AppendLine("Balance DECIMAL NOT NULL,");

            }
        }
    }
}