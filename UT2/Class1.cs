using System;

namespace UT2
{
    [TestFixture]
    public class UT1
    {
        [SetUp]
        //[OneTimeSetUp]
        public void SetUp()
        {
        }

        [TearDown]
        //[OneTimeTearDown]
        public void TearDown()
        {
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = BankAccount();
            Assert.AreEqual(result, 1);
        }
    }
}
