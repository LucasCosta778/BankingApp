using BankingApp.Shared.ValueObjects;
using Flunt.Validations;

namespace BankingApp.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            AddNotifications(new EmailContract(address));
            Address = address;
        }

        public string Address { get; private set; }
    }

    public class EmailContract : Contract<Email>
    {
        public EmailContract(string address)
        {
            Requires().IsEmail(address, "Email");

        }
    }
}