using NUnit.Framework;
using System;
using Bank;

namespace BankAccountTests
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
        public void Adding_Funds_Updates_Balance()
        {
            account.Add(500);

            Assert.AreEqual(1500, account.Balance);
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            // ACT
            account.Withdraw(500);

            // ASSERT
            Assert.AreEqual(500, account.Balance);
        }

        [Test]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            // ARRANGE
            var otherAccount = new BankAccount();

            // ACT
            account.TransferFundsTo(otherAccount, 500);

            // ASSERT
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }
    }
}
