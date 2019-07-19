using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_solution
{
    // implementacja tablicowa, wykorzystująca wagi i kompresję ścieżki
    public class DisjointSet : IDisjointSet
    {
        private int[] parent; //odwołanie do przodka
        private int[] size; //rozmiar drzewa reprezentującego zbiór

        public int Size => parent.Length;

        // konstruktor (nie makonstruktora domyślnego)
        public DisjointSet(int N)
        {
            parent = new int[N];
            size = new int[N];
            for (int i = 0; i < N; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
            NumberOfSubsets = N;
        }

        // Zwraca indeks reprezentanta zbioru, do którego należy element o indeksie `index`
        public int Find(int index) => root(index);

        private int root(int i)
        {
            while (i != parent[i])
            {
                parent[i] = parent[parent[i]];
                i = parent[i];
            }
            return i;
        }

        public bool AreInSameSet(int index1, int index2) => root(index1) == root(index2);

        public void Union(int index1, int index2)
        {
            int i = root(index1), j = root(index2);
            if (size[i] < size[j])
            {
                parent[i] = j;
                size[j] += size[i];
            }
            else
            {
                parent[j] = i;
                size[i] += size[j];
            }
            NumberOfSubsets--;
        }

        // ---- metody dodatkowe, spoza interfejsu

        // Zwraca rozmiar zbioru, do którego należy element o indeksie `index`
        public int SizeOfSubset(int index) => size[root(index)];

        public int NumberOfSubsets { get; private set; }
    }
}
