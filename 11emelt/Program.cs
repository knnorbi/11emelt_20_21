using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11emelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle h1 = new Triangle(1, 2, 3);
            h1.SetSides(2, -2, 2);
            Console.WriteLine(h1.Editable());
            Console.WriteLine(h1.Perimeter());
            Console.ReadLine();
        }
    }
}
