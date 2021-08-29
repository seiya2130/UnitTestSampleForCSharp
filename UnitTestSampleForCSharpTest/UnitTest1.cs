using NUnit.Framework;
using System;

namespace UnitTestSampleForCSharpTest
{   
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10, 5)]
        public void AddTest(int a, int b)
        {
            Assert.AreEqual(a + b, 15);
            Assert.AreNotEqual(a + b, 16);
        }

        [Test]
        [TestCase(10, 5)]
        public void SubtractTest(int a, int b)
        {
            Assert.AreEqual(a - b, 5);
            Assert.AreNotEqual(a - b, 6);
        }

        [Test]
        [TestCase(10, 5)]
        public void MultiplyTest(int a, int b)
        {
            Assert.AreEqual(a * b, 50);
            Assert.AreNotEqual(a * b, 51);
        }

        [Test]
        [TestCase(10, 5)]
        public void DivideTest(int a, int b)
        {
            Assert.AreEqual(a / b, 2);
            Assert.AreNotEqual(a / b, 3);
        }

        [Test]
        [TestCase(null, 5)]
        [TestCase(10, null)]
        [TestCase(null, null)]
        public void NullExceptionTest(int? a, int? b)
        {
            if(a == null || b == null)
            {
                Assert.Throws<NullReferenceException>(
                () => { throw new NullReferenceException(); });
            }
        }
    }
}