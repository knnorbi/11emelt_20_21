using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public override string Email
        {
            get
            {
                return this.ToString().Replace(' ', '.').ToLower() + "@teacher.school.com";
            }
        }
    }
}
