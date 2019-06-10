using System;
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

        [Test]
        public void ShouldBeFizzBuzz()
        {
            Assert.AreEqual("Fizzbuzz", _fizzbuzzC.FizzBuzz(15));
            Assert.AreEqual("Fizzbuzz", _fizzbuzzC.FizzBuzz(30));
            Assert.AreEqual("Fizzbuzz", _fizzbuzzC.FizzBuzz(60));
            Assert.AreNotEqual("Fizzbuzz", _fizzbuzzC.FizzBuzz(63));
        }

        [Test]
        public void ShouldBeNum()
        {
            Assert.AreEqual(4, _fizzbuzzC.FizzBuzz(4));
            Assert.AreEqual(7, _fizzbuzzC.FizzBuzz(7));
            Assert.AreEqual(37, _fizzbuzzC.FizzBuzz(37));
        }

        [Test]
        public void ShouldRun()
        {
            _fizzbuzzC.Run();
        }
    }
}