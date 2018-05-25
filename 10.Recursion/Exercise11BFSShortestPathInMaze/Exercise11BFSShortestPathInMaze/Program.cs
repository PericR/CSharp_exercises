using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11BFSShortestPathInMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] lab =
            {
                {'s', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
            };

            DoBFS(lab);
        }        

        static void DoBFS(char[,] lab)
        {
            int row = 0;
            int col = 0;
            bool pathExist = false;

            Queue<int> rows = new Queue<int>();
            Queue<int> cols = new Queue<int>();
            rows.Enqueue(0);
            cols.Enqueue(0);

            while (rows.Count > 0)
            {
                if (rows.Count > 0)
                {
                    row = rows.Dequeue();
                    col = cols.Dequeue();
                }

                if (lab[row, col] == 'e')
                {
                    pathExist = true;
                    break;
                }

                //check up
                if (row - 1 >= 0 && (lab[row - 1, col] == ' ' || lab[row - 1, col] == 'e'))
                {
                    rows.Enqueue(row - 1);
                    cols.Enqueue(col);
                    if (lab[row-1, col] != 'e')
                    {
                        lab[row - 1, col] = 's';
                    }
                }
                //check right
                if (col + 1 < lab.GetLength(1) && (lab[row, col + 1] == ' ' || lab[row, col + 1] == 'e'))
                {
                    rows.Enqueue(row);
                    cols.Enqueue(col + 1);
                    if (lab[row, col + 1] != 'e')
                    {
                        lab[row, col + 1] = 's';
                    }
                }
                //check down
                if (row + 1 < lab.GetLength(0) && (lab[row + 1, col] == ' ' || lab[row + 1, col] == 'e'))
                {
                    rows.Enqueue(row + 1);
                    cols.Enqueue(col);
                    if (lab[row + 1, col] != 'e')
                    {
                        lab[row + 1, col] = 's';
                    }
                }
                //check left
                if (col - 1 >= 0 && (lab[row, col - 1] == ' ' || lab[row, col - 1] == 'e'))
                {
                    rows.Enqueue(row);
                    cols.Enqueue(col - 1);
                    if (lab[row, col - 1] != 'e')
                    {
                        lab[row, col - 1] = 's';
                    }
                }                
            }
            

            if (pathExist)
            {
                Console.WriteLine("Path found");
            }
            else
            {
                Console.WriteLine("Path isn't found.");
            }
        }
    }
}
