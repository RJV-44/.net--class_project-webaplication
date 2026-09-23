using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTORIAL_3;

namespace TUTORIAL_3
{
    public class Student2
    {
        public int Id; public string Name;
        public int id
        {
            get { return Id; } // read value of id             set { Id = value; } // write value of id 
        }

        public string name
        {
            get { return name; } // read value of id             set { Name = value; } // write value of id 
        }

        //Parameterized Constructure  
        public Student2()
        {
            Id = 1;
            Name = "Unknown";
        }

        //Static Method 
        public Student2(int i, string n)
        {
            Id = i;
            Name = n;
        }
        public void Display()
        {
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Name : " + Name);
        }
    }
}

class Class3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name : rajvi lunagariya");
        Console.WriteLine("Enrollment No : 24SOECE11019 ");


        Student2 s1 = new Student2(101, "Drashti"); Student2 s2 = new Student2(102, "Shreeya"); Student2 s3 = new Student2(103, "Krishna"); Student2 s4 = new Student2(104, "Jinal"); Student2 s5 = new Student2(105, "Jaldhara");

        s1.Display(); s2.Display(); s3.Display(); s4.Display(); s5.Display();
        Console.ReadLine();
    }

}
