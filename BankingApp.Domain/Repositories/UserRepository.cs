using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public bool CPFExist(string cpf)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool EmailExist(string email)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(CPF cpf, decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}