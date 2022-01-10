using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnitTestSampleForCSharp;

namespace UnitTestSampleForCSharpTest
{
    public class GenericTest
    {
        [TestCase("1")]
        [TestCase("a")]
        public void ArrayPropertyTypeTest<T>(T type)
        {
            var t = new Generic<T>();
            t.Prop1 = type;
            Assert.AreEqual(t.Prop1.GetType() == type.GetType(), true);
        }

        [TestCase(1, 1, 2, true)]
        [TestCase(2, 1, 2, true)]
        [TestCase(0, 1, 2, false)]
        [TestCase(3, 1, 2, false)]
        [TestCase(0.1, 0.1, 0.2, true)]//IComparableが実装されていれば呼び出し可能なことの確認ケース
        public void IsValueWithinRangeTest(IComparable value, IComparable from, IComparable to, bool isValueWithin)
        {
            Assert.AreEqual(Generic<Type>.IsValueWithinRange<IComparable>(value, from, to), isValueWithin);
        }

    }
}
