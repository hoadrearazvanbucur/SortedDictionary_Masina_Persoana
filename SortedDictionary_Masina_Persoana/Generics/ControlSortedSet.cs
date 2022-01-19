using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class ControlSortedSet<K, V> where V : IComparable<V>
    {
        private Set<Stored<K, V>>[] hashtable;
        private int size;

        public ControlSortedSet()
        {
            this.size = 1;
            this.hashtable = new Set<Stored<K, V>>[100];
            for (int i = 0; i < size; i++)
                hashtable[i] = new Set<Stored<K, V>>();
        }

        public int hashKey(K key)
        {
            int k = 0;
            for (int i = 0; i < this.size; i++)
                if (this.hashtable[i].Lista.dimensiune() != 0)
                {
                    if (this.hashtable[i].Lista.obtine(0).Data.Key.ToString() == key.ToString())
                        return k;
                    k++;
                }
            k = 0;
            for (int i = 0; i < this.size; i++)
                if (this.hashtable[i].Lista.dimensiune() > 0)
                    k++;
                else
                    return k;
            return k;
        }

        public void put(K key, V value)
        {
            Stored<K, V> data = new Stored<K, V>() { Key = key, Value = value };
            this.hashtable[this.hashKey(key)].adaugare(data);
            this.size++;
            hashtable[size - 1] = new Set<Stored<K, V>>();
        }
        public void remove(K key)
        {
            this.hashtable[this.hashKey(key)] = new Set<Stored<K, V>>();
        }
        public void remove(K key, V value)
        {
            for (int j = 0; j < this.hashtable[this.hashKey(key)].Lista.dimensiune(); j++)
                if (this.hashtable[this.hashKey(key)].Lista.obtine(j).Data.Value.ToString().Equals(value.ToString()) == true)
                    this.hashtable[this.hashKey(key)].Lista.stergere(j);
        }
        public void modificare(K key, K newKey)
        {
            for (int j = 0; j < this.hashtable[this.hashKey(key)].Lista.dimensiune(); j++)
                this.hashtable[this.hashKey(key)].Lista.obtine(j).Data.Key = newKey;
        }
        public void modificare(K key, V value, V valueNou)
        {
            for (int j = 0; j < this.hashtable[this.hashKey(key)].Lista.dimensiune(); j++)
                if (this.hashtable[this.hashKey(key)].Lista.obtine(j).Data.Value.ToString().Equals(value.ToString()) == true)
                    this.hashtable[this.hashKey(key)].Lista.stergere(j);
            this.hashtable[this.hashKey(key)].Lista.adaugare(new Stored<K, V> { Key = key, Value = valueNou });
        }



        public string afisare()
        {
            string text = "";
            for (int i = 0; i < this.size - 1; i++)
            {
                if (this.hashtable[i].Lista.dimensiune() != 0)
                {
                    text += "Persoana:    " + this.hashtable[i].Lista.obtine(0).Data.Key.ToString() + "      Masinile:      ";
                    for (int j = 0; j < this.hashtable[i].Lista.dimensiune(); j++)
                        if (this.hashtable[i].Lista.obtine(j).Data.Value != null)
                            text += this.hashtable[i].Lista.obtine(j).Data.Value.ToString() + "    ,    ";
                    text += "\n";
                }
            }
            return text;
        }


        public Set<Stored<K, V>>[] Hashtable
        {
            get => this.hashtable;
            set => this.hashtable = value;
        }
    }
}
