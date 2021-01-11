using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface
{
    class Circle : IPerimeter
    {
        int r;

        public Circle(int r)
        {
            this.r = r;
        }

        public double Perimeter
        {
            get
            {
                return 2 * r * Math.PI;
            }
        }
    }
}
