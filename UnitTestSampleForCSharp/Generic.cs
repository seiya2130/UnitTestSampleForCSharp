using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSampleForCSharp
{
    public class Generic<T>
    {
        public T Prop1;
        public static bool IsValueWithinRange<Type>(Type value, Type from, Type to) where Type : IComparable
        {
            return value.CompareTo(from) >= 0 && to.CompareTo(value) >= 0;
        }
    }
}
