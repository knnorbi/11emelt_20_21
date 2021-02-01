using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_interface_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamlalo sz1 = new Szamlalo(10);

            foreach (var item in sz1)
            {
                Console.WriteLine(item);
            }


            List<Ember> lista = new List<Ember>();

            lista.Add(new Ember("Peti", 20, 180));
            lista.Add(new Ember("Kati", 18, 160));
            
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.Sort();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
