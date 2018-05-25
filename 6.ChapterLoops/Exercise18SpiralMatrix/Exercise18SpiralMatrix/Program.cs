using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int direction = 1;
            int step = n;
            int i = 0;
            int j = 0;

            for (int count = 1; count <= n * n; count++)
            {
                matrix[i, j] = count;

                if (direction == 1)
                {
                    j++;

                    if (j + 1 >= n || matrix[i, j + 1] != 0)
                    {
                        direction = ChangeDirection(direction);
                    }
                }
                else if (direction == 2)
                {
                    i++;

                    if (i + 1 >= n || matrix[i + 1, j] != 0)
                    {
                        direction = ChangeDirection(direction);
                    }
                }
                else if (direction == 3)
                {
                    j--;

                    if (j - 1 == -1 || matrix[i, j - 1] != 0)
                    {
                        direction = ChangeDirection(direction);
                    }
                }
                else
                {
                    i--;

                    if (i - 1 == -1 || matrix[i - 1, j] != 0) 
                    {
                        direction = ChangeDirection(direction);
                    }
                }

            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

        static int ChangeDirection(int direction)
        {
            int dir = direction + 1;
            if (dir == 5)
            {
                dir = 1;

            }

            return dir;
        }
    }
}
