using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using FibonacciMultipleNumbers;
using WEGAProject;
using SEcondNumbers;


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

        #region WEGA_unit_4

        // zadanie 4 z  http://informatyka.is-great.net/matura/2018/MIN-R2_1P-182.pdf

        [TestMethod]
        public void TestWEGA_Unit_4()
        {
            FileInfo file = new FileInfo(Path.Combine("../../Data/Wega_unit_4", "sygnaly.txt"));

            Assert.IsTrue(file.Exists, $"Brak pliku {file.FullName}");

            WEGA wega = new WEGA(file.FullName);

            string result_4_1 = wega.Unit_4_1();
            Assert.AreEqual("ZAPISZODPOWIEDZIWPLIKUTXT", result_4_1);

            string result_4_2 = wega.Unit_4_2();

            List<string> result_4_3 = wega.Unit_4_3();

            // wynik zktóry ma byc zapisany w  pliku to :
            StringBuilder result = new StringBuilder();
            result.AppendLine(result_4_1);
            result.AppendLine(result_4_2);

            foreach(string line in result_4_3)
            {
                result.AppendLine(line);
            }
  

        }

        #endregion WEGA_unit_4

        [TestMethod]
        public void TestSecondNumbers()
        {
            // https://szkopul.edu.pl/problemset/problem/yZeuTNLgpfpx2vNXSGNRr2RE/site/?key=statement
          //  Assert.AreEqual(true,SEcondNumbers.Numbers.Check(223));
            Assert.AreEqual(false, SEcondNumbers.Numbers.Check(2017));
        }
    }
}
