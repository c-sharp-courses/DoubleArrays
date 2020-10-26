using System;

namespace DoubleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти минимальный элемент массива

            
            int width = 5;
            int height = 5;
            int[ , ] table = new int[width, height];
            Random random = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    table[i, j] = random.Next(100);
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
           

        }
    }
}
