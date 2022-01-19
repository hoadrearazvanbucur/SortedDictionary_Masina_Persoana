using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class ControlView
    {
        private ControlSortedSet<Persoana, Masina> list;

        public ControlView()
        {
            this.list = new ControlSortedSet<Persoana, Masina>();
        }

        public void load()
        {
            int x;
            while((x=legenda())!=0)
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
                        stergerePersoana();
                        break;
                    case 4:
                        stergereMasinaPersoana();
                        break;
                    case 5:
                        modificarePersoana();
                        break;
                    case 6:
                        modificareMasinaPersoana();
                        break;
                    case 7:
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
            list.put(persoana, null);
            Console.WriteLine("Persoana adaugata cu succes");
        }
        public void adaugareMasinaPersoana()
        {
            Console.WriteLine("Introduceti numele,prenumele si anii persoanei careia doriti sa ii adaugati o masina");
            string data = Console.ReadLine();
            Console.WriteLine("Introduceti marca noii masini");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduceti modelul noii masini");
            string model = Console.ReadLine();
            Console.WriteLine("Introduceti pretul noii masini");
            string pret = Console.ReadLine();
            Masina masina = new Masina(marca + "," + model + "," + pret);
            list.put(new Persoana(data), masina);
            Console.WriteLine("Masina adaugata cu succes");
        }
        public void stergerePersoana()
        {
            Console.WriteLine("Introduceti numele,prenumele si anii persoanei care doriti sa o stergeri");
            string data = Console.ReadLine();
            list.remove(new Persoana(data));
            Console.WriteLine("Persoana stearsa cu succes");
        }
        public void stergereMasinaPersoana()
        {
            Console.WriteLine("Introduceti persoana careia doriti sa ii stergeti masina");
            string dataPersoana = Console.ReadLine();
            Console.WriteLine("Introduceti masina pe care doriti sa o stergeti");
            string dataMasina = Console.ReadLine();
            list.remove(new Persoana(dataPersoana), new Masina(dataMasina));
            Console.WriteLine("Masina stearsa cu succes");
        }
        public void modificarePersoana()
        {
            Console.WriteLine("Introduceti datele persoanei pe care doriti sa o modificati");
            string dataPersoana = Console.ReadLine();
            Console.WriteLine("Introduceti datele noii persoane");
            string dataPersoanaNou = Console.ReadLine();
            list.modificare(new Persoana(dataPersoana), new Persoana(dataPersoanaNou));
            Console.WriteLine("Persoana modificata cu succes");
        }
        public void modificareMasinaPersoana()
        {
            Console.WriteLine("Introduceti persoana careia ii doriti sa modificati o masina");
            string dataPersoana = Console.ReadLine();
            Console.WriteLine("Introduceti masina pe care doriti sa o modificati");
            string dataMasina = Console.ReadLine();
            Console.WriteLine("Introduceti noua masina");
            string dataMasinaNou = Console.ReadLine();
            list.modificare(new Persoana(dataPersoana), new Masina(dataMasina),new Masina(dataMasinaNou));
            Console.WriteLine("Masina modificata cu succes");
        }

        public void afisare()
        {
            Console.WriteLine(list.afisare());
        }

        public int legenda()
        {
            Console.WriteLine("\n\n0  Pentru a iesi.");
            Console.WriteLine("1  Pentru a adauga o persoana.");
            Console.WriteLine("2  Pentru a adauga o masina unei persoane.");
            Console.WriteLine("3  Pentru a sterge o persoana");
            Console.WriteLine("4  Pentru a sterge masina unei persoane.");
            Console.WriteLine("5  Pentru a modifica o persoane.");
            Console.WriteLine("6  Pentru a modifica masina unei persoane.");
            Console.WriteLine("7  Pentru a afisa o toate persoanele si masinile corespunzatoare persoanei.");
            return int.Parse(Console.ReadLine());
        }
    }
}
