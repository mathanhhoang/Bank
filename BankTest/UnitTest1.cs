using NUnit.Framework;
using Bank;

namespace BankTest
{
    [TestFixture]
    public class Tests
    {
        private BankAccount account;
        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [Test]
        public void Add_Amount()
        {
            //ACT
            account.Add(500);
            //ASSERT
            Assert.AreEqual(1500, account.Balance);
        }

        [Test]
        public void Withdraw_Amount()
        {
            //ACT
            account.Withdraw(500);
            //ASSERT
            Assert.AreEqual(500, account.Balance);
        }
    }
}
