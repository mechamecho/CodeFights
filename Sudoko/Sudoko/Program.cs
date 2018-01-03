using System;
using System.Collections.Generic;

namespace Sudoko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        bool sudoku2(char[][] grid)
        {
            var GridCheck = new List<char>();
            var RowCheck = new List<char>();
            var ColumnCheck = new List<char>();


            for (var row = 0; row < 9; row++)
            {
                RowCheck.Clear();
                ColumnCheck.Clear();
                for (var column = 0; column < 9; column++)
                {
                    var element = grid[row][column];
                    if (Char.IsDigit(element))
                    {
                        if (RowCheck.Contains(element))
                        {
                            return false;
                        }
                        RowCheck.Add(element);
                    }
                    element = grid[column][row];
                    if (Char.IsDigit(element))
                    {
                        if (ColumnCheck.Contains(element))
                        {
                            return false;
                        }
                        ColumnCheck.Add(element);
                    }
                }
            }

            var k = 0;
            var startrow = 0;
            var startcol = 0;
            while (k < 9)
            {

                GridCheck.Clear();
                for (var row = startrow; row <= (startrow + 2); row++)
                {
                    for (var col = startcol; col <= (startcol + 2); col++)
                    {
                        var element = grid[row][col];
                        Console.Write("row: {0}, col: {1} ", row, col);
                        if (Char.IsDigit(element))
                        {
                            if (GridCheck.Contains(element))
                                return false;
                            GridCheck.Add(element);
                        }
                    }
                }
                if (startcol == 6)
                {
                    startrow += 3;
                    startcol = 0;
                }
                else
                {
                    startcol += 3;
                }

                k++;
            }
            return true;
        }
    }
}
