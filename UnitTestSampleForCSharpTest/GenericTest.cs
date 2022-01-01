using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnitTestSampleForCSharp;

namespace UnitTestSampleForCSharpTest
{
    public class GenericTest
    {
        [TestCase(1, 1, 2, true)]
        [TestCase(2, 1, 2, true)]
        [TestCase(0, 1, 2, false)]
        [TestCase(3, 1, 2, false)]
        [TestCase(0.1, 0.1, 0.2, true)]//IComparableが実装されていれば呼び出し可能なことの確認ケース
        public void IsValueWithinRangeTest(IComparable value, IComparable from, IComparable to, bool isValueWithin)
        {
            Assert.AreEqual(Generic.IsValueWithinRange<IComparable>(value, from, to), isValueWithin);
        }

    }
}
