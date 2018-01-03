using System;
using System.Collections.Generic;

namespace rotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int[][] rotateImage(int[][] a)
        {

            int DimensionLength = a.GetLength(0) - 1;
            List<int> NumbersInOrder = new List<int>();


            for (var row = DimensionLength; row >= 0; row--)
            {
                for (var column = 0; column <= DimensionLength; column++)
                {

                    NumbersInOrder.Add(a[row][column]);
                }
            }

            var ListIndex = 0;

            for (var column = 0; column <= DimensionLength; column++)
            {
                for (var row = 0; row <= DimensionLength; row++)
                {
                    a[row][column] = NumbersInOrder[ListIndex];
                    ListIndex++;
                }
            }




            return a;
        }

    }
}
