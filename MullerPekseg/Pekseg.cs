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
            return this.Nev + " - " + this.Alapitva.Date;
        }
    }
}
