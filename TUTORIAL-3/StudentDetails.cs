using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTORIAL_3;

namespace TUTORIAL_3
{
    class StudentDetails
    {
        private int enroll; private string name;

        //Property Data Member 

        public int e
        {
            get { return enroll; }
            set { enroll = value; }
        }
        public string n
        {
            get { return name; }
            set { name = value; }
        }

        //Empty Constructure 
        public StudentDetails()
        {
        }
        public StudentDetails(int e, string n)
        {
            enroll = e;
            name = n;
        }
        public void Display()
        {
            Console.WriteLine("Enrollment No : " + enroll);
            Console.WriteLine("Name : " + name);
        }
    }
}

class Class7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name : rajvi lunagariya");
        Console.WriteLine("Enrollment No : 24SOECE11019 ");


        StudentDetails s = new StudentDetails(); Console.WriteLine("Enter Enrollment Number : ");
        s.e = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name : "); 
        s.n = Console.ReadLine();

        s.Display(); Console.ReadLine();
    }
} 
 


