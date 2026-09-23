using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class student1

    {
        static int count = 0;
        public student1()
        {
            count++;
        }
        public static void Display()
        {
            Console.WriteLine("Total number of students: " + count);
        }


    }

    class Class19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            student1 s1 = new student1(); student1 s2 = new student1(); student1 s3 = new student1(); student s4 = new student1(); student1 s5 = new student1();
            student1.Display();
        }
    }

}
