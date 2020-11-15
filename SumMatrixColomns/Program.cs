using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMatrixColomns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] numbers = new int[arr[0], arr[1]];

            for (int i = 0; i < arr[0]; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < arr[1]; j++)
                {
                    numbers[i, j] = nums[j];
                }
            }

            List<int> results = new List<int>();
            int result = 0;
            for (int i = 0; i < arr[1]; i++)
            {
                for (int j = 0; j < arr[0]; j++)
                {
                    result += numbers[j, i];
                }
                results.Add(result);
                result = 0;
            }
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
