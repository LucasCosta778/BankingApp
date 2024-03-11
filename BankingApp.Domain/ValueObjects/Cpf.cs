using System.Text.RegularExpressions;
using BankingApp.Shared.ValueObjects;

namespace BankingApp.Domain.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF(string cpf)
        {
            if (!ValidarCPF(cpf))
            {
                throw new Exception("CPF inválido!");
            }
            else
            {
                Cpf = cpf;
            }
        }

        public string Cpf { get; private set; }

        private bool ValidarCPF(string cpf)
        {
            // Remover caracteres não numéricos
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            // Verificar se o CPF tem 11 dígitos
            if (cpf.Length != 11)
            {
                return false;
            }

            // Calcular os dígitos verificadores
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            // Verificar se os dígitos calculados são iguais aos dígitos reais
            return (digito1 == int.Parse(cpf[9].ToString()) && digito2 == int.Parse(cpf[10].ToString()));
        }
    }
}
