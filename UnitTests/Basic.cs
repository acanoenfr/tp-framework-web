using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeCSharp;

namespace UnitTests
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class Basic
    {

        [TestMethod]
        public void HelloYou()
        {
            var name = "Alex";
            var subject = new HelloYou();
            var actual = subject.SayHello(name);
            Assert.AreEqual("Hello Alex", actual);
        }

        [TestMethod]
        public void SumOfTwoNumbers()
        {
            var subject = new PracticeCSharp.Math();
            var actual = subject.Sum(5, 10);
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void DivideOfTwoNumbers()
        {
            var subject = new PracticeCSharp.Math();
            var actual = subject.Divide(10, 2);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void SumTable()
        {
            var integersTable = new List<int> { 1, 2, 3 };
            var subject = new PracticeCSharp.Math();
            var actual = subject.SumTable(integersTable);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Reverse()
        {
            var sentence = "Hello world !";
            var subject = new PracticeCSharp.Sentence();
            var actual = subject.Reverse(sentence);
            Assert.AreEqual("! dlrow olleH", actual);
        }
    }
}
