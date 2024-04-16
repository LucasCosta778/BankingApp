using System.Reflection.Metadata;
using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface ITransferRepository
    {
        void OpenConnection();
        void CloseConnection();
        bool SenderExist(User remetente);
        bool RecipientExist(User destinatario);
        void CreateTransfer(Transfer transfer);

    }
}