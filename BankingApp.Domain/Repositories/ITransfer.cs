using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface ITransferRepository
    {
        
        bool recipientExist(User recipient);
        void CreateTransfer(Transfer transfer);

    }
}