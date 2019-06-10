using NUnit.Framework;
using fizzbuzzC;

namespace Tests
{
    [TestFixture]
    public class fizzbuzzC_Tests
    {

        private FizzbuzzC _fizzbuzzC;
        [SetUp]
        public void FizzbuzzC_RunTest()
        {
            _fizzbuzzC = new FizzbuzzC();
        }

        [Test]
        public void ShouldBeFizz()
        {
            Assert.AreEqual("Fizz", _fizzbuzzC.FizzBuzz(3));
            Assert.AreEqual("Fizz", _fizzbuzzC.FizzBuzz(6));
            Assert.AreEqual("Fizz", _fizzbuzzC.FizzBuzz(63));
            Assert.AreNotEqual("Fizz", _fizzbuzzC.FizzBuzz(4));
        }

        [Test]
        public void ShouldBeBuzz()
        {
            Assert.AreEqual("Buzz", _fizzbuzzC.FizzBuzz(5));
            Assert.AreEqual("Buzz", _fizzbuzzC.FizzBuzz(10));
            Assert.AreEqual("Buzz", _fizzbuzzC.FizzBuzz(50));
            Assert.AreNotEqual("Buzz", _fizzbuzzC.FizzBuzz(34));
        }
    }
}