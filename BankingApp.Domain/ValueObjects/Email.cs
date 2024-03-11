using BankingApp.Shared.ValueObjects;
using Flunt.Validations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BankingApp.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            if (!IsValidEmail(address))
            {
                throw new ArgumentException("Endereço de e-mail inválido", nameof(address));
            }
            Address = address;
        }

        public string Address { get; private set; }

      private bool IsValidEmail(string email)
         {
             // Expressão regular para validar o formato do endereço de e-mail
            string emailRegex = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(emailRegex);

            return regex.IsMatch(email);
        }
    }


}