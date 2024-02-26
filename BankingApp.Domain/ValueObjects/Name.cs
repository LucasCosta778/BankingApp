using System.Diagnostics.Contracts;
using BankingApp.Shared.ValueObjects;
using Flunt.Validations;

namespace BankingApp.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {

            validateName(firstName, "primeiro");
            validateName(lastName, "ultimo");
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public void validateName(string name, string position)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"O {position} nome é inválido!!");
            }

            if(name.Length > 25)
            {
               throw new ArgumentException("Digite um nome válido!"); 
            }
        }


    }
}