using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    numbers[i, j] = nums[j];
                }
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        result += numbers[i, j];
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
