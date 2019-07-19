using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_solution
{
    interface IDisjointSet
    {
        // Konstruktor tworzy strukturę o zadanym rozmiarze
        // Rozmiar struktury nie zmienia się podczas działania

        // Zwraca rozmiar struktury
        int Size { get; }

        // Łączy ze sobą zbiory, do których należa elementy o indeksach `index1`, `index2`,
        // tworząc jeden wspólny zbiór.
        void Union(int index1, int index2);

        // Zwraca indeks reprezentanta (wspólnego) zbioru elementów, 
        // do którego należy element o indeksie `index`
        int Find(int index);

        // zwraca `true` jeśli elementy o indekksach `index1`, `index2` nalezą do tego samego zbioru
        bool AreInSameSet(int index1, int index2);

    }
}
