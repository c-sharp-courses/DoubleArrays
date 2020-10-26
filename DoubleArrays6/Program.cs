using System;

namespace DoubleArrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 5;
            int[,] table = new int[rows, columns];
            Random random = new Random();

            Console.WriteLine("Input Matrix:\n");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = random.Next(100);
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

            int[,] transposedTable = new int[columns, rows];

            Console.WriteLine("Transposed Matrix:\n");

            for (int i = 0; i < table.GetLength(1); i++)
            {
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    transposedTable[i, j] = table[j, i];
                    Console.Write(transposedTable[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();


        }
    }
}
