using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MullerPekseg
{
    class Pekaru
    {

        private string nev;
        private int ar;
        private bool laktozmentes;

        public Pekaru (string nev, int ar, bool laktozmentes)
        {
            this.nev = nev;
            this.ar = ar;
            this.laktozmentes = laktozmentes;
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

        public int Ar
        {
            get
            {
                return this.ar;
            }
            set
            {
                this.ar = value;
            }
        }

        public bool Laktozmentes
        {
            get
            {
                return this.laktozmentes;
            }
            set
            {
                this.laktozmentes = value;
            }
        }

        public string toString()
        {
            return this.Nev + " (" + this.Ar + " Ft / db)";
        }
    }
}
