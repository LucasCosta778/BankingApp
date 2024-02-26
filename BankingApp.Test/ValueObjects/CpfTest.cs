using BankingApp.Domain.ValueObjects;

namespace BankingApp.Test.ValueObject
{
    [TestClass]
    public class CpfTest
    {

        [TestMethod]
        public void ShouldReturnSucessWhenCpfValid()
        {
            string testcpf = "123.427.280-69";

            var cpf = new CPF(testcpf);

            Assert.AreEqual(testcpf, cpf.Cpf);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenCpfInvalid()
        {
            string testcpf = "155-220-155";

            var cpf = new CPF(testcpf);

            Assert.AreNotEqual(testcpf, cpf.Cpf);

        }
    }
}