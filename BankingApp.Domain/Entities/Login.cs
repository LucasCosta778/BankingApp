namespace BankingApp.Domain.Entities
{
    public class Login
    {
        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }

        private void SearchEmailAndSenha(string email, string senha)
        {
            
        }

    }
}