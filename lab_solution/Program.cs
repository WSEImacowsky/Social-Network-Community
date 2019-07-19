using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę obiektów N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę zapytań losowych M: ");
            int M = int.Parse(Console.ReadLine());

            var ds = new DisjointSet(N);

            var rnd = new Random();
            for (int i = 0; i < M; i++)
            {
                int p = rnd.Next(N); // 0..N-1
                int q = rnd.Next(N); // 0..N-1

                if (!ds.AreInSameSet(p, q)) // wywołanie Find
                    ds.Union(p, q);         // wywołanie Union
            }

            Console.WriteLine("Liczba zbiorów: " + ds.NumberOfSubsets);

        }
    }
}
