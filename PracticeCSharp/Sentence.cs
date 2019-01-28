using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            char[] cArray = sentence.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
