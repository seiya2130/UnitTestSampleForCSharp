using NUnit.Framework;

namespace UnitTestSampleForCSharpTest
{   
    [TestFixture]
    public class Tests
    {
        int a;
        int b;

        [SetUp]
        public void Setup()
        {
            this.a = 10;
            this.b = 5;
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
    }
}