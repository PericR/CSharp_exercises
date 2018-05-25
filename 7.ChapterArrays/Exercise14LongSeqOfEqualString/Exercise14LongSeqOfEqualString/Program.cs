using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14LongSeqOfEqualString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[,]
            {
                { "s","qq","s" },
                { "pp", "pp", "s" },
                { "pp", "qq", "s" }
            };

            string bestSequence = "";
            string currentWord;
            int longestSequence = 0;

            //check rows
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentWord = matrix[row, col];
                    int currentSequence = 0;

                    for (int k = col; k < matrix.GetLength(1); k++)
                    {
                        if (currentWord == matrix[row, k])
                        {
                            currentSequence++;
                        }
                    }

                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        bestSequence = currentWord;
                    }
                }
            }

            //check colons
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currentWord = matrix[row, col];
                    int currentSequence = 0;

                    for (int k = row; k < matrix.GetLength(0); k++)
                    {
                        if (currentWord == matrix[k, col])
                        {
                            currentSequence++;
                        }
                    }

                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        bestSequence = currentWord;
                    }
                }
            }

            //check diagonals
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentWord = matrix[row, col];
                    int currentSequence = 0;
                    int i = row;
                    int j = col;

                    do
                    {
                        if (currentWord == matrix[i, j])
                        {
                            currentSequence++;
                        }
                        i++;
                        j++;
                    }
                    while (i < matrix.GetLength(0) && j < matrix.GetLength(1));


                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        bestSequence = currentWord;
                    }
                }
            }

            Console.WriteLine("Longest sequence have word {0} with {1} repetitions", bestSequence, longestSequence);
        }
    }
}
