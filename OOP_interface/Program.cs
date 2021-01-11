using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerimeter[] t = new IPerimeter[3];
            t[0] = new Triangle(1, 2, 3);
            t[1] = new Rectangle(1, 2, 3, 4);
            t[2] = new Circle(4);

            foreach (IPerimeter item in t)
            {
                Console.WriteLine(item.Perimeter);
            }

            Triangle a = new Triangle(1, 2, 3);
            Triangle b = new Triangle(1, 2, 3);

            if (a == b)
            {

            }
        }
    }
}
