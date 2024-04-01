using BankingApp.Domain.Entities;
using BankingApp.Domain.Repositories;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.DataBase
{
    public class SQLiteUserRepository : IUserRepository
    {
        private readonly SQLiteDB _sqliteDB;
        public SQLiteUserRepository(SQLiteDB sqliteDB)
        {
            _sqliteDB = sqliteDB;
        }

        public bool AtualizarUsuario(CPF cpf, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public bool CPFjaExiste(string cpf)
        {
            throw new NotImplementedException();
        }

        public void CriarUsuario(User user)
        {
            throw new NotImplementedException();
        }

        public bool EmailjaExiste(string email)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {

        }
    }
}