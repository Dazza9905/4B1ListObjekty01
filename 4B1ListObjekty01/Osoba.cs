using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B1ListObjekty01
{
    class Osoba
    {
        private int pocet;
        private int vek;

        public Osoba(int pocet, int vek)
        {
            SetPocet(pocet);
            SetVek(vek);
        }

        public Osoba()
        {
            SetPocet(0);
            SetVek(0);
        }



        public void SetPocet(int pocet)
        {
            this.pocet = pocet;
        }
        public int GetPocet()
        {
            return pocet;
        }

        public void SetVek(int vek)
        {
            this.vek = vek;
        }
        public int GetVek()
        {
            return vek;
        }
    }
}
