using System.Reflection.Metadata;
using BankingApp.Domain.Entities;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Repositories
{
    public interface ITransferRepository
    {
        void OpenConnection();
        void CloseConnection();
        bool CPFjaExiste(User remetente);
        bool DestinatarioExiste(User destinatario);
        void CriarTransferencia(Transfer transfer);

    }
}