using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface_example
{
    class Ember : IComparable
    {
        string nev;
        int kor;
        int magassag;

        public Ember(string nev, int kor, int magassag)
        {
            this.nev = nev;
            this.kor = kor;
            this.magassag = magassag;
        }

        public int CompareTo(object obj)
        {
            Ember masik = obj as Ember;
            if (masik == null)
            {
                return 0;                       // dummy
            }

            if (masik.kor > this.kor)
            {
                return -1;
            }

            if (masik.kor < this.kor)
            {
                return 1;
            }

            return 0;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
