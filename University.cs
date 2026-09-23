using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class University
    {
        private string school_name; private string department_name;

        public University(string school_name, string department_name)
        {
            this.school_name = school_name; this.department_name = department_name;
        }
        public void Display()
        {
            Console.WriteLine("School Name: " + school_name);
            Console.WriteLine("Department Name: " + department_name);
        }
    }

    class Class23
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            University u = new University("RK University", "Computer Engineering"); u.Display();
        }


    }
}
