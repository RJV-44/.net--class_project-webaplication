using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class Students
    {
        public int Id; public string Name;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public Students()
        {
            Id = 1;
            Name = "unknown";
        }
        public Students(int i, string n)
        {
            Id = i;
            Name = n;
        }
        public void display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }

    class class5
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");


            Students s = new Students(101, "rajvi"); 
            s.display();
        }

    }
} 
 


