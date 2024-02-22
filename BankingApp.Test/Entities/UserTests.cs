using BankingApp.Domain.Entities;

namespace BankingApp.Test;

[TestClass]
public class UserTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var user = new User(1, "Lucas", "lucas@gmail.com", "1234", "45555555", Domain.Enums.EUserType.comum);
    }
}