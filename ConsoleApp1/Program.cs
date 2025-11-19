using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };

            Console.WriteLine("tablica przed: { " + string.Join(", ", tablica) + " }");
            for (int i = 0; i < tablica.Length / 2; i++)
            {
                int tymczasowa = tablica[i];
                tablica[i] = tablica[tablica.Length - 1 - i];
                tablica[tablica.Length - 1 - i] = tymczasowa;
            }

            Console.WriteLine("Tablica po: { " + string.Join(", ", tablica) + " }");
        }
    }
}