using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    class Knjiga : IComparable
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Naslov { get; set; }
        public int GodinaIzdanja { get; set; }
        public int BrojPrimjeraka { get; set; }

        public override string ToString()
        {
            return this.Autor + ": " + this.Naslov;
        }

        public int CompareTo(object obj)
        {
            int rezultat;
            rezultat = this.Autor.CompareTo(((Knjiga)obj).Autor);
            if(rezultat == 0)
            {
                rezultat = this.Naslov.CompareTo(((Knjiga)obj).Naslov);
            }

            return rezultat;
        }
    }
}
