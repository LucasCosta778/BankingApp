
namespace BankingApp.Domain.Entities
{
    public class Transferencia
    {
        public Transferencia(int idEmissor, int idRemetente, decimal valorTransferencia)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            IdEmissor = idEmissor;
            IdRemetente = idRemetente;
            ValorTransferencia = valorTransferencia;
            DataTransferencia = DateTime.Now;
        }

        public string Numero { get; private set; }
        public int IdEmissor { get; private set; }
        public int IdRemetente { get; private set; }
        public decimal ValorTransferencia { get; private set; }
        public DateTime DataTransferencia { get; private set; }

    }

}