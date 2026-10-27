using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class Student
    {
        private int enroll; private string name; private string branch;

        public void AcceptData(int e, string n, string b)
        {
            enroll = e;
            name = n;
            branch = b;
        }

        public void DisplayData()
        {
            Console.WriteLine("---------Student Details--------");
            Console.WriteLine("Enrollment No : " + enroll);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Branch : " + branch);
        }
        class T3Q1
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Name : krishari");
                Console.WriteLine("Enrollment No : 24SOECE11001 ");

                Student s1 = new Student(); Student s2 = new Student();

                s1.AcceptData(101, "Drashti", "Computer Science");
                Console.WriteLine("Details of Student 1"); s1.DisplayData();

                s2.AcceptData(102, "rajvi", "Computer Science");
                Console.WriteLine("Details of Student 2"); s2.DisplayData();
            }
        }

    }


}
