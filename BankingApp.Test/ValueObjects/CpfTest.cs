using BankingApp.Domain.ValueObjects;

namespace BankingApp.Test.ValueObject
{
    [TestClass]
    public class CpfTest
    {

        [TestMethod]
        public void ShouldReturnSucessWhenCpfValid()
        {
            string testcpf = "935.555.070-79";

            var cpf = new CPF(testcpf);

            Assert.AreEqual(testcpf, cpf.Cpf);

        }


        [TestMethod]
        public void testInvalidCpf()
        {
            string testcpf = "155-220-155";

            Assert.ThrowsException<Exception>(() => new CPF(testcpf));
        }

    }
}