using System.Reflection.Metadata;
using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface ITransferRepository
    {
        
        bool RemetenteExiste(User remetente);
        bool DestinatarioExiste(User destinatario);
        void CreateTransfer(Transfer transfer);

    }
}