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
        [TestCase(null, 5)]
        [TestCase(10, null)]
        [TestCase(null, null)]
        public void NullExceptionTest(int? a, int? b)
        {
            Assert.Throws<NullReferenceException>(
            () => { UnitTestSampleForCSharp.Calculator.CheckNull(a, b); });

        }

        [Test]
        [TestCase(10, 5)]
        public void NotNullExceptionTest(int? a, int? b)
        {
            Assert.DoesNotThrow(
            () => { UnitTestSampleForCSharp.Calculator.CheckNull(a, b); });
        }

        [Test]
        [TestCase(10, 5)]
        public void AddTest(int a, int b)
        {
            Assert.AreEqual(UnitTestSampleForCSharp.Calculator.Add(a, b), 15);
            Assert.AreNotEqual(UnitTestSampleForCSharp.Calculator.Add(a, b), 16);
        }

        [Test]
        [TestCase(10, 5)]
        public void SubtractTest(int a, int b)
        {
            Assert.AreEqual(UnitTestSampleForCSharp.Calculator.Subtract(a, b), 5);
            Assert.AreNotEqual(UnitTestSampleForCSharp.Calculator.Subtract(a, b), 6);
        }

        [Test]
        [TestCase(10, 5)]
        public void MultiplyTest(int a, int b)
        {
            Assert.AreEqual(UnitTestSampleForCSharp.Calculator.Multiply(a, b), 50);
            Assert.AreNotEqual(UnitTestSampleForCSharp.Calculator.Multiply(a, b), 51);
        }

        [Test]
        [TestCase(10, 5)]
        public void DivideTest(int a, int b)
        {
            Assert.AreEqual(UnitTestSampleForCSharp.Calculator.Divide(a, b), 2);
            Assert.AreNotEqual(UnitTestSampleForCSharp.Calculator.Divide(a, b), 3);
        }
    }
}