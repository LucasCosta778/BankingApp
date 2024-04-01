

using BankingApp.Domain.Entities;
using BankingApp.Domain.Enums;
using BankingApp.Domain.Repositories;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.UseCases
{
  public class CreateUserUseCase
  {
    private readonly IUserRepository _userRepository;
    public CreateUserUseCase(IUserRepository repository)
    {
      _userRepository = repository;
    }

    private void CriarUsuario(
    string primeiroNome,
    string ultimoNome,
    string senha,
    decimal saldo,
    EUserType tipo,
    string cpf,
    string email)
    {

      //Gerar value objects   
      var name = new Name(primeiroNome, ultimoNome);
      var Email = new Email(email);
      var Cpf = new CPF(cpf);

      //Verificar se cpf já está cadastrado
      if (_userRepository.CPFjaExiste(cpf)) 
        throw new Exception("CPF já existe!");

      //Verificar se email já está cadastrado
      if (_userRepository.EmailjaExiste(email)) 
        throw new Exception("Email já existe!");

      //Gerar entidade
      var user = new User(name, Email, senha, Cpf, saldo, tipo);

      //Salvar usuário
      _userRepository.CriarUsuario(user);

    }

  }
}