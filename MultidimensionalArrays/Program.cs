using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[arr[0], arr[1]];

            for (int row = 0; row < arr[0]; row++)
            {
                int[] numbers = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < arr[1]; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int total = 0;
            foreach (var item in matrix)
            {
                total += item;
            }
            Console.WriteLine(total);
        }
    }
}
