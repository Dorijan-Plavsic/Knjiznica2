using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    class Posudba : IComparable
    {
        public Ucenik Ucenik { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public int BrojDana { get; set; }
        public DateTime DatumVracanja { get { return this.DatumPosudbe.AddDays(this.BrojDana); } }

        public int CompareTo(object obj)
        {
            int rezultat;
            rezultat = this.DatumPosudbe.CompareTo(((Posudba)obj).DatumPosudbe);
            return rezultat;
        }

        public override string ToString()
        {
            return this.DatumPosudbe.ToShortDateString()
                + " - " + this.DatumVracanja.ToShortDateString()
                + ": " + this.Knjiga.ToString()
                + " -> " + this.Ucenik.ToString();
        }
    }
}
