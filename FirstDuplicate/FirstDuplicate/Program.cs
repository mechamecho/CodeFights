using System;
using System.Collections.Generic;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int firstDuplicate(int[] a)
        {
            HashSet<int> Set = new HashSet<int>();
            // List<int> ArrayNums= new List<int>();
            foreach (int number in a)
            {
                if (Set.Contains(number))
                {
                    return number;
                }
                Set.Add(number);

            }
            return -1;
        }
    }
}
