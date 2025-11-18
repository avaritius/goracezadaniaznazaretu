using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anna", "Bartek", "Celina", "Dawid", "Ewa" };

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}