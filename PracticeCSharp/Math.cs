using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp
{
    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int SumTable(IEnumerable<int> integersTable)
        {
            int sum = 0;
            foreach (int num in integersTable)
            {
                sum += num;
            }
            return sum;
        }
    }
}
