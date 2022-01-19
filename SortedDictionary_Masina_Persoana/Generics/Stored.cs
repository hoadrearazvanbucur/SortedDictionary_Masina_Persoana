using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class Stored<K, V> : IComparable<Stored<K, V>> where V : IComparable<V>
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

        public int CompareTo([AllowNull] Stored<K, V> other)
        {
            return 1;
        }
    }
}
