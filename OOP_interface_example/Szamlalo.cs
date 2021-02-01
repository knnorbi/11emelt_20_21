using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface_example
{
    class Szamlalo : IEnumerable
    {
        int max;

        public Szamlalo(int max)
        {
            this.max = max;
        }

        public IEnumerator GetEnumerator()
        {
            return new SzamlaloLepteto(max);
        }
    }
}
