using System;

namespace UnitTests
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a + b; // intentional mistake!
        }
    }
}
