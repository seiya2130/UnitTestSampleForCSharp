using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using UnitTestSampleForCSharp;

namespace UnitTestSampleForCSharpTest
{
    [TestFixture]
    public class InterfaceTest
    {
        [Test]
        public void SampleTest()
        {
            var mock = new Mock<ISampleInterface>();
            mock.Setup(x => x.Sample()).Returns("Hello Mock");

            Assert.AreEqual(mock.Object.Sample(), "Hello Mock");
        }
    }
}
