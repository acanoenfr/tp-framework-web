using PracticeCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp.Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            return list;
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            var list = new List<int>();
            for (int i = current; i <= max; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public int SumNaturalNumbers(int n)
        {
            int somme = 0;
            for (int i = 1; i <= n; i++)
            {
                somme += i;
            }
            return somme;
        }

        private int ComputeSum(int n, int current)
        {
            int somme = 0;
            for (int i = current; i <= n; i++)
            {
                somme += i;
            }
            return somme;
        }

        public bool IsPrime(int n)
        {
            if (n < 0)
            {
                return IsPrime(-n);
            }
            else if (n <= 3)
            {
                return true;
            }
            else
            {
                int sqrt = (int)System.Math.Sqrt(n);
                for (int i = 2; i <= sqrt; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool IsPalindrome(string text)
        {
            var sentence = new Sentence();
            if (sentence.Reverse(text) == text)
            {
                return true;
            }
            return false;
        }
    }
}
