using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class ControlView
    {
        private ControlSortedSet<Persoana, Masina> list;
        private int size;

        public ControlView()
        {
            this.size = 0;
            this.list = new ControlSortedSet<Persoana, Masina>(this.size);
        }

        public void load()
        {
            int x;
            while((x=legenda())!=4)
            {
                Console.Clear();
                switch (x)
                {
                    case 1:
                        adaugarePersoana();
                        break;
                    case 2:
                        adaugareMasinaPersoana();
                        break;
                    case 3:
                        afisare();
                        break;
                }
            }
        }

        public void adaugarePersoana()
        {
            Console.WriteLine("Introduceti numele persoanei:");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele persoanei:");
            string prenume = Console.ReadLine();
            Console.WriteLine("Introduceti ani persoanei:");
            string ani = Console.ReadLine();
            Persoana persoana = new Persoana(nume + "," + prenume + "," + ani);
            //list.Hashtable[size++].Add(new Stored<Persoana, Masina> { Key = persoana, Value = null/*new Masina("")*/ });
        }

        public void adaugareMasinaPersoana()
        {
            Console.WriteLine("Introduceti numele persoanei careia doriti sa ii adaugari o masina");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti marca noii masini");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduceti modelul noii masini");
            string model = Console.ReadLine();
            Console.WriteLine("Introduceti pretul noii masini");
            string pret = Console.ReadLine();
            Masina masina = new Masina(marca + "," + model + "," + pret);
            //list.Hashtable[list.getKey(nume)].Add(new Stored<Persoana, Masina> { Key = list.getKey(nume), Value =masina});
        }

        public void afisare()
        {
            list.afisare();
        }


        public int legenda()
        {
            Console.WriteLine("\n\n1  Pentru a adauga o persoana.");
            Console.WriteLine("2  Pentru a adauga o masina unei persoane.");
            Console.WriteLine("3  Pentru a afisa o toate persoanele si masinile corespunzatoare persoanei.");
            Console.WriteLine("0  Pentru a iesi.");
            return int.Parse(Console.ReadLine());
        }
    }
}
