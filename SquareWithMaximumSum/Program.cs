using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = GetMatrix(arr);

            int sum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] > sum)
                    {
                        sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.Write($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}" + "\n" + $"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}" + "\n" + $"{sum}");


        }

        static int[,] GetMatrix(int[] arr)
        {
            
            int[,] matrix = new int[arr[0], arr[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
    }
}
