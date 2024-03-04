using BankingApp.Domain.Commands;
using BankingApp.Domain.Entities;
using BankingApp.Domain.Repositories;
using BankingApp.Shared.Commands;
using BankingApp.Shared.Handlers;
using Flunt.Notifications;

namespace BankingApp.Domain.Handlers
{
    public class TransferHandle : Notifiable<Notification>, IHandler<CreateTransferCommand>
    {
        private readonly ITransferRepository _repository;
        public TransferHandle(ITransferRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTransferCommand command)
        {
            //verificar se destinatário existe
            if (_repository.recipientExist(command.Destinatario))
                AddNotification("Transfer.Destinatario", "Destinatario não existe!");

            //gerar entidade
            var transfer = new Transfer(command.Remetente, command.Destinatario, command.ValorTransferencia);
            //salvar informações
            _repository.CreateTransfer(transfer);
            
            return new CommandResult(true, "Transferência realizada com sucesso!");

        }
    }

}