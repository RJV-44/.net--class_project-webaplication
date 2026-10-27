
using System;
using System.Collections.Generic;
using System.Linq;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public double Marks { get; set; }
    }

    class Program12
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentID = 1, Name = "Rajvi", Course = "B.Tech", Marks = 85 },
                new Student { StudentID = 2, Name = "Amit", Course = "BCA", Marks = 65 },
                new Student { StudentID = 3, Name = "Priya", Course = "B.Tech", Marks = 92 },
                new Student { StudentID = 4, Name = "Rahul", Course = "BCA", Marks = 75 },
                new Student { StudentID = 5, Name = "Neha", Course = "B.Tech", Marks = 60 }
            };

            var result = from s in students
                         where s.Marks > 70
                         orderby s.Marks ascending
                         select s;

            Console.WriteLine("Students with Marks Greater Than 70:");
            Console.WriteLine("------------------------------------");

            foreach (Student s in result)
            {
                Console.WriteLine("Student ID: " + s.StudentID);
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Course: " + s.Course);
                Console.WriteLine("Marks: " + s.Marks);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
