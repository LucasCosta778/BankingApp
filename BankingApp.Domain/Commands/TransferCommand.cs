using BankingApp.Domain.Entities;
using BankingApp.Shared.Commands;

namespace BankingApp.Domain.Commands
{
    public class CreateTransferCommand : ICommand
    {
        public User Remetente { get;  set; }
        public User Destinatario { get;  set; }
        public decimal ValorTransferencia { get;  set; }
    }
}