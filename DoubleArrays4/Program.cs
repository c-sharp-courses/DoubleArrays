using System;

namespace DoubleArrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти индекс максимального элемента массива

            int rows = 4;
            int columns = 5;
            int[,] table = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = random.Next(100);
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            int rowMaxIndex = 0;
            int columnMaxIndex = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[rowMaxIndex, columnMaxIndex] < table[i, j])
                    {
                        rowMaxIndex = i;
                        columnMaxIndex = j;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine($"index of the maximal element = [{rowMaxIndex},{columnMaxIndex}]");
        }
    }
}
