using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSampleForCSharp
{
    public static class Calculator
    {
        public static void CheckNull(int? a, int? b)
        {
            if (a == null || b == null)
            {
                throw new NullReferenceException();
            }
        }

        public static int Add(int a, int b)
        {
            CheckNull(a, b);
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            CheckNull(a, b);
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            CheckNull(a, b);
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            CheckNull(a, b);
            return a / b;
        }
    }
}
