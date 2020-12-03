using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "Petike";
            s1.grade = 2;
            s1.typeOfClass = 'C';

            Teacher t1 = new Teacher();
            t1.name = "Jozsi bacsi";
            t1.classes = new List<int>();
            
            

            SchoolPerson[] schoolPeople = { s1, t1 };

            //for (int i = 0; i < schoolPeople.Length; i++)
            //{
            //    SchoolPerson sp = schoolPeople[i];
            //    ...
            //}


            foreach (SchoolPerson sp in schoolPeople)
            {
                Console.WriteLine(sp.name);
                Student student = sp as Student;
                if (student != null)
                {
                    Console.WriteLine(student.grade);
                }
            }

        }
    }
}
