using System;
using System.Collections.Generic;
using System.IO;

namespace WEGAProject
{
    // zadanie 4 z http://informatyka.is-great.net/matura/2018/MIN-R2_1P-182.pdf
    public class WEGA
    {
        private readonly string[] lines;

        public WEGA(string fileName)
        {
            lines = File.ReadAllLines(fileName);
        }

        public string Unit_4_1()
        {
            string word = "";
            int wordSkip = 40; // co 40 linia
            int leterIndex = 10 - 1; // 10-ta litera w słowie

            for(int i = wordSkip - 1; i <= lines.Length; i+= wordSkip)
            {
                string line = lines[i];
                word += line[leterIndex];
            }

            return word;
        }

        public string Unit_4_2()
        {
            string word = "";
            int maxDiffLetters = 0;

            for (int i = 0;i < lines.Length; i++)
            {
                string line = lines[i];
                int diffLettersNumber = DiffLettersNumber(line);
                if (diffLettersNumber > maxDiffLetters)
                {
                    maxDiffLetters = diffLettersNumber;
                    word = line;
                }
            }

            return $"{word} {maxDiffLetters}";
        }

        private int DiffLettersNumber(string word)
        {
            Dictionary<char, int> lettters = new Dictionary<char, int>();
            // zliczenie liter bez użycia linq
            for (int j = 0; j < word.Length; j++)
            {
                char letter = word[j];
                if (lettters.TryGetValue(letter, out int number))
                {
                    lettters[letter] = number++;
                }
                else
                {
                    lettters.Add(letter, 1);
                }

            }

            return lettters.Count;
        }

        public List<string> Unit_4_3()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
              
                if (CheckWordDistance(line) ) { result.Add(line); }
            }

            return result; ;
        }

        private bool CheckWordDistance(string word)
        {
            for (int j = 1; j < word.Length; j++)
            {
                for (int k = 0;k < j; k++)
                {
                    int distance = LettersDistance(word[k], word[j]);
                    if (distance > 10)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private int LettersDistance(char first,char second)
        {
            int firstNr = (int)first;
            int secondNr = (int)second;

            return Math.Abs(firstNr - secondNr); ;
        }

    }
}
