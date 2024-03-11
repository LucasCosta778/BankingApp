using BankingApp.Domain.ValueObjects;

namespace BankingApp.Test.ValueObject
{
     [TestClass]
    public class EmailTest
    {

        [TestMethod]
        public void ValidEmail()
        {
            string email = "lucascta44@gmail.com";

            var Email = new Email(email);

            Assert.AreEqual(email,Email.Address);

        }

          [TestMethod]
        public void InvalidEmail()
        {
            string email = "lucasctaemail.com";

            Assert.ThrowsException<ArgumentException>(()=> new Email(email));

        }
    }
}