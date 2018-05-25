using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25LargestAreaEqualNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = FillMatrix(7, 9);
            

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}, ", matrix[i, j]);
                }

                Console.WriteLine();
            }

            
            int bestCount = 0;
            int bestElement = matrix[0, 0];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == int.MinValue)
                    {
                        continue;
                    }

                    Queue<int[]> matched = new Queue<int[]>();
                    int countEqualElements = 1;
                    int current = matrix[row, col];
                    matrix[row, col] = int.MinValue;

                    countEqualElements = CheckSides(matrix, matched, current, row, col, countEqualElements);

                    while (matched.Count > 0)
                    {
                        int currentRow = matched.Peek()[0];
                        int currentCol = matched.Dequeue()[1];

                        countEqualElements = CheckSides(matrix, matched, current, currentRow, currentCol, countEqualElements);
                    }


                    if (countEqualElements > bestCount)
                    {
                        bestElement = current;
                        bestCount = countEqualElements;
                    }
                }

            }

            Console.WriteLine("Best element is {0}, and it apears {1} times.", bestElement, bestCount);         
        }

        static int CheckSides(int[,] matrix, Queue<int[]> matched, int current, int row, int col, int countEqualElements)
        {
            if (row - 1 >= 0)//look up
            {
                if (current == matrix[row - 1, col])
                {
                    matched.Enqueue(new int[] { row - 1, col });
                    matrix[row - 1, col] = int.MinValue;
                    countEqualElements++;
                }
            }

            if (col + 1 < matrix.GetLength(1))//look Right
            {
                if (current == matrix[row, col + 1])
                {
                    matched.Enqueue(new int[] { row, col + 1 });
                    countEqualElements++;
                    matrix[row, col + 1] = int.MinValue;
                }
            }

            if (row + 1 < matrix.GetLength(0))//look down
            {
                if (current == matrix[row + 1, col])
                {
                    matched.Enqueue(new int[] { row + 1, col });
                    countEqualElements++;
                    matrix[row + 1, col] = int.MinValue;
                }
            }

            if ((col - 1) >= 0)//Look left
            {
                if (current == matrix[row, col - 1])
                {
                    matched.Enqueue(new int[] { row, col - 1 });
                    countEqualElements++;
                    matrix[row, col - 1] = int.MinValue;
                }
            }

            return countEqualElements;
        }

        static int[,] FillMatrix(int n, int m)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(0, 4);
                }
            }

            return matrix;
        }
    }
}
