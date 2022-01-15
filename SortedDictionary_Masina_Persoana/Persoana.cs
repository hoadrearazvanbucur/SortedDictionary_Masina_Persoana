using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class Persoana : IComparable<Persoana>
    {
        private string nume, prenume;
        private int ani;

        public Persoana(string data)
        {
            string[] dataSplit = data.Split(",");
            this.nume = dataSplit[0];
            this.prenume = dataSplit[1];
            this.ani = int.Parse(dataSplit[2]);
        }

        public override string ToString() => this.nume + "," + this.prenume + "," + this.ani;
        public override bool Equals(object obj) => (obj as Persoana).ToString() == this.ToString();
        public string afisare()
        {
            string text = "";
            text += "Nume: " + this.nume;
            text += "\nPrenume: " + this.prenume;
            text += "\nAni: " + this.ani + "\n\n";
            return text;
        }
        public int CompareTo([AllowNull] Persoana other)
        {
            if (other.ani < this.ani)
                return -1;
            else
                if (other.ani == this.ani)
                return 0;
            else
                return -1;
        }

        public string Nume
        {
            get => this.nume;
            set => this.nume = value;
        }
        public string Prenume
        {
            get => this.prenume;
            set => this.prenume = value;
        }
        public int Ani
        {
            get => this.ani;
            set => this.ani = value;
        }
    }
}
