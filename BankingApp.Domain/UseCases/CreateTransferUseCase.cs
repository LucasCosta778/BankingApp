using BankingApp.Domain.Entities;
using BankingApp.Domain.Repositories;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.UseCases
{
  public class CreateTransferUseCase
  {
    private readonly IUserRepository _userRepository;
    private readonly ITransferRepository _transferRepository;
    public CreateTransferUseCase(ITransferRepository repository, IUserRepository userRepository)
    {
      _transferRepository = repository;
      _userRepository = userRepository;
    }

    public void CreateTransfer(User Remetente, User Destinatario, decimal valorTransferencia)
    {
      //Chamar método para validar a transferência
      TransferIsValid(Remetente, Destinatario, valorTransferencia);
      //Gerar entidade
      var transferencia = new Transfer(Remetente, Destinatario, valorTransferencia);
      //Atualizar saldo dos usuários
      Remetente.Saldo -= valorTransferencia;
      Destinatario.Saldo += valorTransferencia;

      //Salvar transferência no banco
      _transferRepository.CreateTransfer(transferencia);

      //Atualizar usuários
      _userRepository.UpdateUser(Remetente.Cpf, Remetente.Saldo);
      _userRepository.UpdateUser(Destinatario.Cpf, Destinatario.Saldo);

    }

    public void TransferIsValid(User Remetente, User Destinatario, decimal valorTransferencia)
    {
      if (Remetente == null || Destinatario == null)
      {
        throw new Exception("Usuário não existe!");
      }
      if (Remetente.Tipo == Enums.EUserType.lojista)
      {
        throw new Exception("Você não pode realizar transferências");
      }

      if (Remetente == Destinatario)
      {
        throw new Exception("Você não pode realizar transferências para si mesmo!");

      }

      if (Remetente.Saldo < valorTransferencia || valorTransferencia == 0)
      {
        throw new Exception("Saldo insuficiente!");

      }
    }







  }


}