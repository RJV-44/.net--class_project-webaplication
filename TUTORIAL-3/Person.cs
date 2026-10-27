using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
       internal class Person
    {
        public int age { get; set; }
        public string gender { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("------------person details----------");
            Console.WriteLine("Age of person : " + age);
            Console.WriteLine("Gender of person : " + gender);
        }
    }

    //childe class 
    class Student1 : Person
    {
        public int enroll_no { get; set; }
        public string name { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("------------student details----------");
            Console.WriteLine("Enrollment number of student : " + enroll_no);
            Console.WriteLine("Name of student : " + name);
        }
    }

    class Class15
    {
        public static void Main(string[] args)
        {
            Student1 s = new Student1();
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            Console.Write("Enter Student Age: ");
            s.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Gender: "); s.gender = Console.ReadLine();


            Console.Write("Enter Student Enrollment Number: "); s.enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: "); s.name = Console.ReadLine();

            s.DisplayPersonDetails();
            s.DisplayStudentDetails(); Console.ReadLine();
        }
    }

}
