using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortedDictionary_Masina_Persoana
{
    public class Masina : IComparable<Masina>
    {
        private string marca, model;
        private int pret;

        public Masina(string data)
        {
            string[] dataSplit = data.Split(",");
            this.marca = dataSplit[0];
            this.model = dataSplit[1];
            this.pret = int.Parse(dataSplit[2]);
        }

        public override string ToString() => this.marca + "," + this.marca + "," + this.pret;
        public override bool Equals(object obj) => (obj as Masina).ToString() == this.ToString();
        public string afisare()
        {
            string text = "";
            text += "Marca: " + this.marca;
            text += "\nModel: " + this.model;
            text += "\nPret: " + this.pret+"\n\n";
            return text;
        }
        public int CompareTo([AllowNull] Masina other)
        {
            if (other.pret < this.pret)
                return -1;
            else
                if (other.pret == this.pret)
                return 0;
            else
                return -1;
        }

        public string Marca
        {
            get => this.marca;
            set => this.marca = value;
        }
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public int Pret
        {
            get => this.pret;
            set => this.pret = value;
        }
    }
}
