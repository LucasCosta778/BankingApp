using BankingApp.Domain.Commands;
using BankingApp.Domain.Entities;
using BankingApp.Domain.Repositories;
using BankingApp.Domain.ValueObjects;
using BankingApp.Shared.Commands;
using BankingApp.Shared.Handlers;
using Flunt.Notifications;

namespace BankingApp.Domain.Handlers
{
    public class UserHandler : Notifiable<Notification>, IHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateUserCommand command)
        {
            //Verificar se cpf já está cadastrado
            if (_repository.CpfExist(command.Cpf))
                AddNotification("CPF", "Esse cpf já existe!");

            //verificar se email já está cadastrado
            if (_repository.EmailExist(command.Email))
                AddNotification("Email", "Esse email já existe!");

            //Gerar value objects para usuário
            var name = new Name(command.FirstName, command.LastName);
            var email = new Email(command.Email);
            var cpf = new CPF(command.Cpf);
            var saldo = command.Saldo;
            var senha = command.Senha;
            var tipo = command.Tipo;

            //Gerar entidade
            var user = new User(1, name, email, senha, cpf, saldo, tipo);

            //Salvar as informações
            _repository.CreateUser(user);

            return new CommandResult(true, "Cadastro realizado com sucesso!");

        }
    }
}