using System;

namespace DoubleArrays5
{
    class Program
    {
            static void Main(string[] args)
            {
                // Найти горки

                int rows = 4;
                int columns = 5;
                int[,] table = new int[rows, columns];
                Random random = new Random();

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[i, j] = random.Next(100);
                        Console.Write(table[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            Console.WriteLine();
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if((i == 0 || table[i - 1, j] <= table[i, j]) &&
                           (j == 0 || table[i, j - 1] <= table[i, j]) &&
                           (i == table.GetLength(0) - 1 || table[i + 1, j] <= table[i, j]) &&
                           (j == table.GetLength(1) - 1 || table[i, j + 1] <= table[i, j]))
                        {
                            Console.WriteLine(table[i, j]);
                        }

                    }
                }


            }
       
    }
}