using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface IUserRepository
    {
        void OpenConnection();
        void CloseConnection();
        bool UpdateUser(CPF cpf, decimal valor);
        bool EmailExist(string email);
        bool CPFExist(string cpf);
        void CreateUser(User user);
        
    }
}