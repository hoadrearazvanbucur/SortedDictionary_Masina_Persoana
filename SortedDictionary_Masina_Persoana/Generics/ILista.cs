using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public interface ILista<T>
    {
        void adaugare(T data);
        void adaugareStart(T data);
        void stergere(int index);
        void stergere(T data);
        bool exista(T data);
        bool listaGoala();
        int pozitieData(T data);
        int dimensiune();
        Node<T> obtine(int index);
        void seteaza(T data, int index);
        void sort();
        string afisare();
        void sort(Comparer<T> comparator);
    }
}
