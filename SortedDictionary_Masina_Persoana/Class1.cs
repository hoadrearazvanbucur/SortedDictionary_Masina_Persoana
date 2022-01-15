using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class Class1 : IComparable<string>
    {
        public int CompareTo([AllowNull] string other)
        {
            return 1;
        }
    }
}
