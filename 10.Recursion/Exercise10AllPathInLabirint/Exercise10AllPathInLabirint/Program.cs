using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10AllPathInLabirint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting coordinates");
            Console.Write("Enter row: ");
            int startRow = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int startCol = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end coordinates");
            Console.Write("Enter row: ");
            int endRow = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int endCol = int.Parse(Console.ReadLine());

            lab[endRow, endCol] = 'e';
            CheckNextCell(startRow, startCol);
        }
        static Stack<char> path = new Stack<char>();

        static char[,] lab =
            {
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };

        static void CheckNextCell(int row, int col)
        {
            //Check if we are still in labirint
            if ((row < 0) || (row >= lab.GetLength(0)) || (col < 0) || (col >= lab.GetLength(1)))
            {
                path.Pop();
                return;
            }

            if (lab[row, col] == 'e')
            {
                Console.WriteLine("Path found: ");
                PrintPath();
            }

            if(lab[row,col]!=' ')
            {
                //current cell isn't free 
                if (path.Count > 0)
                {
                    path.Pop();
                }
                return;
            }

            lab[row, col] = 's';//Mark as visited

            path.Push('U');
            CheckNextCell(row - 1, col);//check up
            path.Push('R');
            CheckNextCell(row, col + 1);//check right
            path.Push('D');
            CheckNextCell(row + 1, col);//check down
            path.Push('L');
            CheckNextCell(row, col - 1);//check left

            lab[row, col] = ' ';//Mark cell as free aggain

            if (path.Count > 0)
            {
                path.Pop();
            }
        }

        static void PrintPath()
        {
            if (path.Count > 0)
            {
                char[] pathForPrint = path.ToArray();

                for (int i = (pathForPrint.Length - 1); i >= 0; i--)
                {
                    Console.Write("{0} ", pathForPrint[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
