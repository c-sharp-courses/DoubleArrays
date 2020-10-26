using System;

namespace DoubleArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти минимальный элемент массива


            int rows = 4;
            int columns = 5;
            int[,] table = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i <table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = random.Next(100);
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int min = table[0, 0];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (min > table[i, j])
                    {
                        min = table[i, j];
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine($"min = {min}");

        }
    }
}
