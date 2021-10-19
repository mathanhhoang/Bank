using NUnit.Framework;
using Bank;
namespace UT
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
            var result = 1;
            Assert.AreEqual(result, 1);
        }
    }
}
