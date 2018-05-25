using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12SquareMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter matrice size: ");
            int size = int.Parse(Console.ReadLine());

            PrintUpToDownMatrice(size);
            PrintUpDownMatrice(size);
            PrintDijagonalMatrice(size);
            PrintSpiralMatrice(size);
        }

        static void PrintMatrice(int[,] matrice)
        {
            for(int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write("{0}, ", matrice[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintUpToDownMatrice(int size)
        {
            int count = 1;

            int[,] matrice = new int[size, size];
            int row = 0;
            int col = 0;
            for(int i = 0; i < (size * size); i++)
            {
                matrice[row, col] = count++;

                row++;
                if (row == size)
                {
                    row = 0;
                    col++;
                }
            }

            PrintMatrice(matrice);

        }

        static void PrintUpDownMatrice(int size)
        {
            int count = 1;

            int[,] matrice = new int[size, size];
            int row = 0;
            int col = 0;
            bool down = true;

            for(int i = 0; i < (size * size); i++)
            {
                matrice[row, col] = count++;

                if (down)
                {
                    row++;
                }
                else
                {
                    row--;
                }

                if (row == size || row == -1)
                {
                    col++;
                    down = !down;

                    if (down)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }
            }

            PrintMatrice(matrice);
        }

        static void PrintDijagonalMatrice(int size)
        {
            int count = 1;

            int[,] matrice = new int[size, size];
            int row = size-1;
            int rowControler = 1;
            int col = 0;
            int colControler = 1;

            for(int i = 0; i < (size * size); i++)
            {
                matrice[row, col] = count;
                row++;
                col++;
                count++;

                if (row >= size)
                {
                    if (col >= size)
                    {
                        col = 1;
                        row = 0;
                    }
                    else
                    {
                        rowControler++;
                        if (rowControler == size + 1)
                        {
                            rowControler = size;
                        }
                        row -= rowControler;
                        col = 0;
                    }
                }

                if (col >= size)
                {
                    colControler++;
                    col = colControler;
                    row = 0;
                }
            }

            PrintMatrice(matrice);
        }

        static void PrintSpiralMatrice(int size)
        {
            int count = 1;

            int[,] matrice = new int[size, size];
            int row = 0;
            int col = 0;
            int directionControl = 0;
            int stepControl = size;
            int steps = 0;

            for (int i = 0; i < (size * size); i++)
            {
                matrice[row, col] = count;
                count++;
                steps++;

                if (steps == stepControl)
                {
                    steps = 0;
                    if (directionControl == 0 || directionControl == 2) 
                    {
                        stepControl--;
                    }
                    directionControl++;
                    if (directionControl == 4)
                    {
                        directionControl = 0;
                    }
                }

                switch (directionControl)
                {
                    case 0:
                        row++;
                        break;
                    case 1:
                        col++;
                        break;
                    case 2:
                        row--;
                        break;
                    case 3:
                        col--;
                        break;
                }
            }

            PrintMatrice(matrice);
        }
    }
}
