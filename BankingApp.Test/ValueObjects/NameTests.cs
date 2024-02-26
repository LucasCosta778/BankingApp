using BankingApp.Domain.ValueObjects;

namespace BankingApp.Test.ValueObject
{
    [TestClass]
    public class NameTest
    {

        [TestMethod]
        public void ShouldReturnSucessWhenNameValid()
        {
            string firstName = "Lucas";
            string lastName = "Costa";

            var name = new Name(firstName, lastName);

            Assert.AreEqual(firstName, name.FirstName);
            Assert.AreEqual(lastName, name.LastName);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("", "Doe")]
        [DataRow("John", "")]
        [DataRow("", "")]
        [DataRow("JohnWithALongNameThatExceedsTwentyFiveCharacters", "Doe")]
        [DataRow("John", "DoeWithALongLastNameThatExceedsTwentyFiveCharacters")]
        public void ShouldThrowArgumentException(string firstName, string lastName)
        {

            Assert.ThrowsException<ArgumentException>(() => new Name(firstName, lastName));
        }
    }
}