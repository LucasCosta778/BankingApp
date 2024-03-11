namespace BankingApp.Test.Handlers
{
    [TestClass]
    public class UserHandlerTest
    {

        [TestMethod]
        public void ShouldReturnErrorWhenCpfExist()
        {
            string testcpf = "935.555.070-79";

            var cpf = new CPF(testcpf);

            Assert.AreEqual(testcpf, cpf.Cpf);

        }
        [TestMethod]
        public void ShouldReturnErrorWhenCpfEmailExist()
        {
            string testcpf = "935.555.070-79";

            var cpf = new CPF(testcpf);

            Assert.AreEqual(testcpf, cpf.Cpf);

        }
    }
}