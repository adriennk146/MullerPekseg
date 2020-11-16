using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MullerPekseg
{
    class Pekseg
    {

        private string nev;
        private List<Pekaru> termekek;
        private DateTime alapitva;

        public Pekseg(string nev)
        {
            this.nev = nev;
            this.alapitva = DateTime.Now;
            this.termekek = new List<Pekaru>();
        }

        public string Nev
        {
            get
            {
                return this.nev;
            }
            set
            {
                this.nev = value;
            }
        }

        public List<Pekaru> Termekek
        {
            get
            {
                return this.termekek;
            }
            set
            {
                this.termekek = value;
            }
        }

        public DateTime Alapitva
        {
            get
            {
                return this.alapitva;
            }
            set
            {
                this.alapitva = value;
            }
        }

        public string toString()
        {
            return this.Nev + " - " + this.Alapitva.Year+". "+this.Alapitva.Month+". "+this.Alapitva.Day+".";
        }

        public string Statisztika()
        {
            double osszAr = 0;
            int minAr = 0;
            int minIndex = 0;
            int maxAr = int.MinValue;
            int maxIndex = 0;
            double laktozmentes = 0;
            for(int i =0;i< this.Termekek.Count; i++)
            {
                osszAr += termekek[i].Ar;
                if (termekek[i].Ar < minAr)
                {
                    minAr = termekek[i].Ar;
                    minIndex = i;
                }
                if (termekek[i].Ar > maxAr)
                {
                    maxAr = termekek[i].Ar;
                    maxIndex = i;
                }
                if (termekek[i].Laktozmentes)
                {
                    laktozmentes++;
                }
            }
            return this.Nev + ":\n" +
                "Alapítva: " + this.Alapitva.Year + ". " + this.Alapitva.Month + ". " + this.Alapitva.Day + ".\n\n" +
                "Pékáruk: " + this.Termekek.Count + " db\n" +
                "Átlag ár: " + Math.Round(osszAr / this.Termekek.Count,1) + " Ft\n" +
                "Legolcsóbb termék: " + this.Termekek[minIndex].toString() + "\n" +
                "Legdrágább termék: " + this.Termekek[maxIndex].toString() + "\n" +
                "Laktózmentes termékek: "+laktozmentes+" db, "+Math.Round(laktozmentes/termekek.Count*100)+"%";
        }
    }
}
