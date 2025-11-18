using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i] * 2;
            }

            Console.WriteLine("tablica A: { " + string.Join(", ", A) + " }");
            Console.WriteLine("tablica B po operacji: { " + string.Join(", ", B) + " }");
        }
    }
}