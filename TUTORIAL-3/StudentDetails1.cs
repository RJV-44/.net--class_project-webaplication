using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTORIAL_3;

namespace TUTORIAL_3
{

    class StudentDetails1
    {
        private int enroll; private string name; private string course;

        public StudentDetails1(int e, string n, string c)
        {
            enroll = e; name = n;
            course = c;
        }
        public void Display()
        {
            Console.WriteLine("Enrollment No : " + enroll);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Course : " + course);
        }
    }
}

class Class8
{
    static void Main()
    {
        Console.WriteLine("Name : rajvi lunagariya");
        Console.WriteLine("Enrollment No : 24SOECE11019 ");


        Console.WriteLine("Enter Enrollment Number : "); int e = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name : "); string n = Console.ReadLine();

        Console.WriteLine("Enter Course : "); string c = Console.ReadLine();

        StudentDetails1 s = new StudentDetails1(e, n, c);

        s.Display(); Console.ReadLine();
    }
} 


