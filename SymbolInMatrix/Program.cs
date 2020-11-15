using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] characters = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    characters[i, j] = chars[j];
                }
            }
            char charToSearch = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(charToSearch == characters[i, j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{charToSearch} does not occur in the matrix");
        }
    }
}
