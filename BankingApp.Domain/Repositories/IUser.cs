using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface IUserRepository
    {
        void OpenConnection();
        void CloseConnection();
        bool AtualizarUsuario(CPF cpf, decimal valor);
        bool EmailjaExiste(string email);
        bool CPFjaExiste(string cpf);
        void CriarUsuario(User user);
        
    }
}