using System;

namespace SEcondNumbers
{
    //https://szkopul.edu.pl/problemset/problem/yZeuTNLgpfpx2vNXSGNRr2RE/site/?key=statement
    public static class Numbers
    {
        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;
        }
        public static bool Check(int number)
        {
            string numberStr = number.ToString();
            for( int i = 1; i < numberStr.Length ; i++)
            {
                int firstNr = int.Parse(numberStr.Substring(0, i));

                if (numberStr.Substring(i,1) != "0")
                {
                    int secondNr = int.Parse(numberStr.Substring(i));

                    if (IsPrime(firstNr) && IsPrime(secondNr)) { return true; }
                }  
            }
            return false;

        }
    }
}
