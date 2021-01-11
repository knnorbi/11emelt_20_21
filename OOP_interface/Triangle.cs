using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface
{
    class Triangle : IPerimeter, IComparable
    {
        int a;
        int b;
        int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public virtual double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        public int CompareTo(object obj)
        {
            return Perimeter.CompareTo(((IPerimeter)obj).Perimeter);
        }
    }
}
