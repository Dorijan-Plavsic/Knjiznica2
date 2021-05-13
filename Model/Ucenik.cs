using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    class Ucenik : IComparable
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int Razred { get; set; }

        public override string ToString()
        {
            return this.Prezime + " " + this.Ime + ", " + this.Razred;
        }

        public int CompareTo(object obj)
        {
            int rezultat;
            rezultat = this.Prezime.CompareTo(((Ucenik)obj).Prezime);
            if(rezultat == 0)
            {
                rezultat = this.Ime.CompareTo(((Ucenik)obj).Ime);
            }

            return rezultat;
        }

    }
}
