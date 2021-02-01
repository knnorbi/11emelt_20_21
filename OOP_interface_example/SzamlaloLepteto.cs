using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface_example
{
    class SzamlaloLepteto : IEnumerator
    {
        int max;
        int current;

        public SzamlaloLepteto(int max)
        {
            this.max = max;
            current = 0;
        }

        public object Current
        {
            get
            {
                return current;
            }
        }

        public bool MoveNext()
        {
            if (current >= max)
            {
                return false;
            }

            current++;
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
