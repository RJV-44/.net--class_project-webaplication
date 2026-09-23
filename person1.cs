using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class person1
    {
        private int age; private string name;

        public person1(string name, int age)

        {
            this.age = age;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class Class20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");



            person1 p1 = new person1("rajvi", 20);
            p1.Display();


        }
    }

}
