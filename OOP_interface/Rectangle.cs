using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface
{
    class Rectangle : Triangle
    {
        int d;

        public Rectangle(int a, int b, int c, int d) : base(a, b, c)
        {
            this.d = d;
        }

        public override double Perimeter
        {
            get
            {
                return base.Perimeter + d;
            }
        }
    }
}
