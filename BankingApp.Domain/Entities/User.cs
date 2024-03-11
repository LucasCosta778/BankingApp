
using System.Security.Cryptography.X509Certificates;
using BankingApp.Domain.Enums;
using BankingApp.Domain.ValueObjects;
using BankingApp.Shared.Entities;

namespace BankingApp.Domain.Entities
{
    public class User : Entity
    {
        public User(int id, Name nome, Email email, string senha, CPF cpf, decimal saldo, EUserType tipo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Saldo = saldo;
            Tipo = tipo;
        }

        public int Id { get; private set; }
        public Name Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public CPF Cpf { get; private set; }
        public decimal Saldo { get; set; }
        public EUserType Tipo { get; private set; }

       
    }
}