using BankingApp.Domain.Entities;
using BankingApp.Domain.Repositories;

namespace BankingApp.Test.Mocks
{
    public class FakeUserRepository : IUserRepository
    {
        public bool CpfExist(string cpf)
        {
            if (cpf == "9999999")
                return true;

            return false;
        }

        public void CreateUser(User user)
        {

        }

        public bool EmailExist(string email)
        {
            if (email == "lucascta@gmail.com")
                return true;

            return false;
        }
    }
}