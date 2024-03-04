using System.Runtime.CompilerServices;

namespace BankingApp.Domain.Repositories
{
    public interface ILogin
    {
        public void CheckEmailAndSenhaIsSameUser();
    }
}