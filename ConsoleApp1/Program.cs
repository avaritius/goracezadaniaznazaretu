using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 5, 1, 4, 2, 8 };

            Console.WriteLine("tablica przed: { " + string.Join(", ", tablica) + " }");

            for (int i = 0; i < tablica.Length - 1; i++)
            {
                for (int j = 0; j < tablica.Length - 1 - i; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int tymczasowa = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tymczasowa;
                    }
                }
            }

            Console.WriteLine("tablica po: { " + string.Join(", ", tablica) + " }");
        }
    }
}