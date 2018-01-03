using System;
using System.Collections.Generic;

namespace isCryptSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        bool isCryptSolution(string[] crypt, char[][] solution)
        {
            var CharList = new List<char>();
            var NumList = new List<char>();
            Char zeroLetter = ' ';
            for (var row = 0; row < solution.GetLength(0); row++)
            {
                Console.Write("Letter: {0}, Number: {1} ", solution[row][0], solution[row][1]);
                CharList.Add(solution[row][0]);
                NumList.Add(solution[row][1]);
                if (Char.GetNumericValue(solution[row][1]) == 0)
                {
                    zeroLetter = solution[row][0];
                    // Console.Write(zeroLetter);
                }
            }

            string firstNum = "";
            string secondNum = "";
            string value = "";

            for (var i = 0; i < crypt.Length; i++)
            {
                var word = crypt[i];
                if (word[0] == (zeroLetter))
                {
                    Console.Write(word.Length);
                    if (word.Length != 1)
                        return false;
                }

                foreach (char letter in word)
                {
                    if (i == 0)
                    {
                        firstNum += NumList[CharList.IndexOf(letter)];
                    }
                    else if (i == 1)
                    {
                        secondNum += NumList[CharList.IndexOf(letter)];
                    }
                    else
                        value += NumList[CharList.IndexOf(letter)];
                }
            }


            Console.Write(firstNum);
            if (Convert.ToInt64(firstNum) + Convert.ToInt64(secondNum) != Convert.ToInt64(value))
            {
                return false;
            }


            return true;

        }

    }
}
