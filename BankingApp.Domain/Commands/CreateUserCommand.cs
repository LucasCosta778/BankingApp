using BankingApp.Domain.Enums;
using BankingApp.Shared.Commands;

namespace BankingApp.Domain.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; private set; }
        public decimal Saldo { get; set; }
        public EUserType Tipo { get; set; }
    }
}