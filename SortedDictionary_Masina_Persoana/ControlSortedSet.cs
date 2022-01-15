using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class ControlSortedSet<K, V> where V : IComparable<V>
    {
        private SortedSet<Stored<K, V>>[] hashtable;
        private int size;

        public ControlSortedSet(int size)
        {
            this.size = size;
            this.hashtable = new SortedSet<Stored<K, V>>[size];
            for (int i = 0; i < size; i++)
                hashtable[i] = new SortedSet<Stored<K, V>>();
        }

        public int hashKey(K key)
        {
            return key.ToString().Length % hashtable.Length;
        }

        public void put(K key, V value)
        {
            Stored<K, V> data = new Stored<K, V>() { Key = key, Value = value };
            this.hashtable[hashKey(key)].Add(data);
        }

        public SortedSet<Stored<K, V>> getKey(K key)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.hashtable[i] != null)
                    return hashtable[i];
                        //?
            }
            return hashtable[1];
        }


        public string afisare()
        {
            string text = "";
            for (int i = 0; i < this.size; i++){
                if (this.hashtable[i] != null)
                    foreach (var x in hashtable[i])
                        text += x.Value + "\n";
                text += "\n";
            }
            return text;
        }

        public void remove(K key)
        {
            int p = this.hashKey(key), k = 0, s = 0;
            SortedSet<Stored<K, V>> list = this.hashtable[p];
            foreach (Stored<K, V> l in list)
            {
                if (l.Key.Equals(key) == true)
                    s = k;
                k++;
            }
            //list.RemoveAt(s);
        }
        public V get(K key)
        {
            int p = this.hashKey(key);
            SortedSet<Stored<K, V>> list = this.hashtable[p];
            foreach (Stored<K, V> l in list)
            {
                if (l.Key.Equals(key) == true)
                    return l.Value;
            }
            return default;
        }

        public SortedSet<Stored<K, V>>[] Hashtable
        {
            get => this.hashtable;
            set => this.hashtable = value;
        }
    }
}
