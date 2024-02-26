using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface IUserRepository
    {
        bool CpfExist(string cpf);
        bool EmailExist(string email);
        void CreateUser(User user);
        
    }
}