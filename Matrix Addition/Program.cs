using static System.Console;

namespace Matrix_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = {
            {1, 2, 3},
            {4, 5, 6}
       
            };

            int[,] B = {
            {7, 8, 9},
            {10, 11, 12}
       
            };

            int[,] C = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    WriteLine($"{A[i, j]} + {B[i, j]} = {C[i, j]} ");
                }
            }

            WriteLine("Matrix C = ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Write($"{C[i, j]} ");
                }
                WriteLine();
            }

            ReadKey();












        }
    }
}
