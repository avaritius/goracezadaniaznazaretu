using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 7, 10, 25, 18, 0 };

            int evenCount = 0;
            int oddCount = 0;

            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"liczba parzystych: {evenCount}");
            Console.WriteLine($"liczba nieparzystych: {oddCount}");
        }
    }
}