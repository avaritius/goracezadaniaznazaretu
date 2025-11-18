using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"najmniejszy element: {min}");
            Console.WriteLine($"najwiekszy element: {max}");
        }
    }
}