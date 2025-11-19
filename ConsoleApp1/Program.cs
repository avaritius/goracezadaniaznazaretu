using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5, 10, 15, 20 };

            Console.Write("podaj liczbe, ktora chcesz znalezc w tablicy: ");
            int szukanaLiczba = int.Parse(Console.ReadLine());

            bool czyZnaleziono = false;
            int indeks = -1;

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == szukanaLiczba)
                {
                    czyZnaleziono = true;
                    indeks = i;
                    break; 
                }
            }

            if (czyZnaleziono)
            {
                Console.WriteLine($"liczba {szukanaLiczba} znajduje sie w tablicy na indeksie {indeks}");
            }
            else
            {
                Console.WriteLine($"liczba {szukanaLiczba} nie zostala znaleziona w tablicy");
            }
        }
    }
}