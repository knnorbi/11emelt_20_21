using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_example
{
    abstract class Person : ISaveable
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public void Save(string path)
        {
            string[] tmp = { name, Email };
            File.WriteAllLines(path, tmp);
        }

        public abstract string Email
        {
            get;
        }
    }
}
