using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13LargestAreaOfCell
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] lab =
            {
                {' ',' ',' ','+',' ',' ',' ',' ',' ',' ','+',' ',' ',' ', },
                {' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ','+',' ',' ', },
                {' ',' ',' ','+',' ',' ',' ',' ',' ',' ','+',' ',' ',' ', },
                {'+','+','+','*','+','+','+','+',' ',' ','+',' ',' ',' ', },
                {' ',' ',' ','+',' ',' ',' ',' ','+',' ',' ','+',' ',' ', },
                {' ',' ',' ','+',' ',' ',' ',' ','+','+',' ','+',' ',' ', },
                {' ',' ',' ','+',' ',' ',' ',' ',' ',' ','+',' ',' ',' ', },
            };


            int largestArea = 0;

            for(int row = 0; row < lab.GetLength(0); row++)
            {
                for(int col = 0; col < lab.GetLength(1); col++)
                {
                    int currentArea = FindLargestArea(lab, row, col);
                    if (currentArea > largestArea)
                    {
                        largestArea = currentArea;
                    }
                }
            }

            Console.WriteLine(largestArea);

            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    Console.Write("{0} ", lab[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int FindLargestArea(char[,] lab, int start, int end)
        {
            Queue<int[]> visited = new Queue<int[]>();
            visited.Enqueue(new int[] { start, end });
            int row = 0;
            int col = 0;
            int counter = 0;

            while (visited.Count > 0)
            {
                row = visited.Peek()[0];
                col = visited.Dequeue()[1];

                //check up
                if(CheckSide(row - 1, col, lab))
                {
                    visited.Enqueue(new int[] { row - 1, col });
                    counter++;
                }
                //check right
                if (CheckSide(row, col + 1, lab))
                {
                    visited.Enqueue(new int[] { row, col + 1 });
                    counter++;
                }
                //check down
                if (CheckSide(row + 1, col, lab))
                {
                    visited.Enqueue(new int[] { row + 1, col });
                    counter++;
                }
                //check left
                if (CheckSide(row, col - 1, lab))
                {
                    visited.Enqueue(new int[] { row, col - 1 });
                    counter++;
                }
            }

            return counter;
        }

        static bool CheckSide(int row, int col, char[,] lab)
        {
            bool isValid = false;

            if (row >= 0 && row < lab.GetLength(0) && col >= 0 && col < lab.GetLength(1) && lab[row, col] == ' ')
            {
                isValid = true;
                lab[row, col] = '*';
            }

            return isValid;
        }
    }
}
