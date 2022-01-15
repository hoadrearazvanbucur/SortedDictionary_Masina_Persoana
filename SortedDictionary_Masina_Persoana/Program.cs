using System;
using System.Collections.Generic;

namespace SortedDictionary_Masina_Persoana
{
    public class Program
    {
        static void Main(string[] args)
        {
            //test();
            ControlView control = new ControlView();
            control.load();
        }



        public void test()
        {
            //SortedSet<string> players = new SortedSet<string>(new Class1());
            ControlSortedSet<Persoana, Masina> test = new ControlSortedSet<Persoana, Masina>(5);

            SortedSet<Stored<Persoana, Masina>>[] a = new SortedSet<Stored<Persoana, Masina>>[3];
            a[0] = new SortedSet<Stored<Persoana, Masina>>();
            a[1] = new SortedSet<Stored<Persoana, Masina>>();
            a[2] = new SortedSet<Stored<Persoana, Masina>>();
            Stored<Persoana, Masina> t1 = new Stored<Persoana, Masina> { Key = new Persoana("Razvan,a,1"), Value = new Masina("masina1,a,1") };
            Stored<Persoana, Masina> t2 = new Stored<Persoana, Masina> { Key = new Persoana("Razvan,a,1"), Value = new Masina("masina2,a,1") };
            Stored<Persoana, Masina> t3 = new Stored<Persoana, Masina> { Key = new Persoana("Ana,a,1"), Value = new Masina("masina3,a,1") };

            a[0].Add(t1);
            a[1].Add(t2);
            a[2].Add(t3);

            string text = "";
            for (int i = 0; i < 3; i++)
            {
                foreach (var x in a[i])
                    text += x.Value + "  |  ";
                text += "\n";
            }
            Console.WriteLine(text);
        }
    }
}
