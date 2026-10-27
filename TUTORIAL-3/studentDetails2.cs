using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class studentDetails2
    {

        public int enroll_no { get; set; }
        public string name { get; set; }
    }
    class Class12
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");


            studentDetails2 studentDetails = new studentDetails2();

            Console.Write("Enter Enrollment Number : ");
            studentDetails.enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name : "); studentDetails.name = Console.ReadLine();

            Console.WriteLine("=========Student Details:===========");

            Console.WriteLine("Enrollment Number: " + studentDetails.enroll_no);
            Console.WriteLine("Name: " + studentDetails.name);
            Console.ReadLine();
        }
    }
}



