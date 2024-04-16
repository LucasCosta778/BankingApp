using System.Data.SQLite;
using BankingApp.Domain.Entities;

namespace BankingApp.Domain.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly string _connectionstring;
        public TransferRepository(string connectionString)
        {
            _connectionstring = connectionString;
        }
        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void CreateTransfer(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public bool RecipientExist(User destinatario)
        {
            throw new NotImplementedException();
        }

        public bool SenderExist(User remetente)
        {
            throw new NotImplementedException();
        }
    }
}