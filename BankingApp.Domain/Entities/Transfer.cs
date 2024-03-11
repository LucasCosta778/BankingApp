
using BankingApp.Shared.Entities;

namespace BankingApp.Domain.Entities
{
    public class Transfer : Entity
    {
        public Transfer(User remetente, User destinatario, decimal valorTransferencia)
        {
            CheckTransfer(remetente, destinatario, valorTransferencia);

            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            Remetente = remetente;
            Destinatario = destinatario;
            ValorTransferencia = valorTransferencia;
            DataTransferencia = DateTime.Now;

            Remetente.Saldo -= valorTransferencia;
            Destinatario.Saldo += valorTransferencia;
        }

        public string Numero { get; private set; }
        public User Remetente { get; private set; }
        public User Destinatario { get; private set; }
        public decimal ValorTransferencia { get; private set; }
        public DateTime DataTransferencia { get; private set; }


        private void CheckTransfer(User remetente, User destinatario, decimal valorTransferencia)
        {
            if (remetente.Tipo == Enums.EUserType.lojista)
            {
                throw new Exception("Você não pode realizar transferências");
            }

            if (remetente == destinatario)
            {
                 throw new Exception("Você não pode realizar transferências para si mesmo!");

            }

            if (remetente.Saldo < valorTransferencia || valorTransferencia == 0)
            {
                 throw new Exception("Saldo insuficiente!");

            }

        }


    }

}