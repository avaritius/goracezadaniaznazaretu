using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] macierz = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += macierz[i, i];
            }

            Console.WriteLine($"suma elementow na glownej przekatnej: {suma}");
        }
    }
}