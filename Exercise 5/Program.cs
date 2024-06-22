using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            WriteLine("Enter number of lines: ");
            int lines = int.Parse(ReadLine());

            WriteLine("Enter number of columns: ");
            int col = int.Parse(ReadLine());

            int[,] matrix = new int[lines, col];

            WriteLine();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                    Write($"{matrix[i, j]} ");
                }
                WriteLine();
            }

            WriteLine();

            WriteLine("Enetr number to find: ");
            int num = int.Parse(ReadLine());

            int find = 0;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == num) find++;
                }
            }

            WriteLine($"Number repeates {find} times ");


            ReadLine();
        }
    }
}
