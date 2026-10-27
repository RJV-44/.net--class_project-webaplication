using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Employee4
    {
        public void EmpStatus()
        {
            Console.WriteLine("Employee working");
        }
    }

    class Department1 : Employee4
    {
        //new keyword hide method 
        public new void EmpStatus()
        {
            Console.WriteLine("Employee is not working");
        }
    }

    class Class22
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            Department1 d = new Department1();

            d.EmpStatus();
        }
    }

}
