using NUnit.Framework;
using fizzbuzzC;

namespace Tests
{
    [TestFixture]
    public class fizzbuzzC_Tests
    {

        private FizzbuzzC _fizzbuzzC;
        [SetUp]
        public void FizzbuzzC_ShouldBeFizzbuzz()
        {
            _fizzbuzzC = new FizzbuzzC();
        }

        [Test]
        public void ShouldBeFizz()
        {
            Assert.AreEqual("Fizz", _fizzbuzzC.Fizz(3));
            Assert.AreEqual("Fizz", _fizzbuzzC.Fizz(6));
            Assert.AreEqual("Fizz", _fizzbuzzC.Fizz(63));
        }
    }
}