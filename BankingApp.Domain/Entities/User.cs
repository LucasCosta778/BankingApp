
using BankingApp.Domain.Enums;
using BankingApp.Domain.ValueObjects;

namespace BankingApp.Domain.Entities
{
    public class User
    {
        public User(int id, Name name, Email email, string senha, CPF cpf, EUserType tipo)
        {
            Id = id;
            Name = name;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Tipo = tipo;
        }

        public int Id { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public CPF Cpf { get; private set; }
        public EUserType Tipo { get; private set; }
    }
}