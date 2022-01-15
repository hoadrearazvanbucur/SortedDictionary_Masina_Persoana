using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class Stored<K,V> : IComparable<V> where V : IComparable<V>
    {
        private K key;
        private V value;

        public K Key
        {
            get => this.key;
            set => this.key = value;
        }
        public V Value
        {
            get => this.value;
            set => this.value = value;
        }

        public int CompareTo(V other)
        {
            return this.value.CompareTo(other);
        }
    }
}
