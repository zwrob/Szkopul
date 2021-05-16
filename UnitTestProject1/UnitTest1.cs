using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FibonacciMultipleNumbers;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacciMultipleNumbers()
        {
            //Test zadania : https://szkopul.edu.pl/problemset/problem/fHvpNTuOnzJOkPN_8VIxdhnS/site/?key=statement

            Dictionary<int, string> testNumbers = new Dictionary<int, string>();
            testNumbers.Add(0, "TAK");
            testNumbers.Add(5, "TAK");
            testNumbers.Add(4, "TAK");
            testNumbers.Add(12, "NIE");
            testNumbers.Add(11, "NIE");
            testNumbers.Add(10, "TAK");

            foreach(var nr in testNumbers)
            {
                string result = FibonacciNumbersProduct.CheckNumber(nr.Key);
                Assert.AreEqual(nr.Value, result,$"dla {nr.Key}");
            }
         
        }
    }
}
