using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13MaxSumPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size for the matrix n*m (must be at least 3*3 to work).\nEnter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = FillMatrix(n, m);
            PrintMatrix(matrix);

            int maxSum = int.MinValue;
            int currentSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < (matrix.GetLength(0) - 2); row++)
            {
                for (int col = 0; col < (matrix.GetLength(1) - 2); col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestCol = col;
                        bestRow = row;
                    }
                }
            }

            Console.WriteLine("Maximal sum is: {0}\nBest Platform:\n", maxSum);

            for (int i = bestRow; i < bestRow + 3; i++) 
            {
                for (int j = bestCol; j <bestCol + 3; j++) 
                {
                    Console.Write("{0,3}, ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        static int[,] FillMatrix(int n, int m)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-50, 50);
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}, ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
