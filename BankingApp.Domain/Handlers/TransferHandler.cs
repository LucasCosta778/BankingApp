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
            if (_repository.DestinatarioExiste(command.Destinatario))
                  throw new Exception("Destinatário inválido!");
            //Verificar se o remetente existe
            if (_repository.RemetenteExiste(command.Destinatario))
                  throw new Exception("Remetente inválido!");


            //Gerar entidade
            var transfer = new Transfer(command.Remetente, command.Destinatario, command.ValorTransferencia);
            //Salvar informações no banco
            _repository.CreateTransfer(transfer);
            
            return new CommandResult(true, "Transferência realizada com sucesso!");

        }
    }

}