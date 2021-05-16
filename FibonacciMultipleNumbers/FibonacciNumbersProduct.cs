using System;
using System.Collections.Generic;

namespace FibonacciMultipleNumbers
{
    /// <summary>
    /// rozwiązanie zadania https://szkopul.edu.pl/problemset/problem/fHvpNTuOnzJOkPN_8VIxdhnS/site/?key=statement
    /// </summary>
    public static class FibonacciNumbersProduct
    {

        public static string CheckNumber(int number)
        {
            List<int> fibonacciNumbers = new List<int>() { 0, 1 };
            int lastIndex = fibonacciNumbers.Count - 1;
            int currentNumber = 0; // fibonacciNumbers[lastIndex];

            List<int> dividers = new List<int>(); // tablica dzielników
            do
            {
                if (number == currentNumber) { return "TAK"; } // na liczny number * 1;

                currentNumber = fibonacciNumbers[lastIndex - 1] + fibonacciNumbers[lastIndex];

                // jesli nalicza z ciągu fibonacciego jest dzieliikiem , to wstawialmy ją do talbicy dzielników
                if (number % currentNumber == 0)
                {
                    dividers.Add(currentNumber);
                }
                // sprawdzamy ilośczyn składników
                for (int i = 0; i < dividers.Count; i++)
                {
                    if (dividers[i] * currentNumber == number)
                    {
                        return "TAK";
                    }
                }

                fibonacciNumbers.Add(currentNumber);
                lastIndex++;
            }
            while (currentNumber < number);
            return "NIE";

        }

    }
}
