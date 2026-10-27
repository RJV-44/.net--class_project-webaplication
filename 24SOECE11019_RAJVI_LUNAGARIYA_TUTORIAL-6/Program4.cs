
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    delegate void StudentInfo();

    class Program4
    {
        static void DisplayName()
        {
            Console.WriteLine("Student Name: Rajvi Lunagariya");
        }

        static void DisplayCourse()
        {
            Console.WriteLine("Course: B.Tech");
        }

        static void DisplaySemester()
        {
            Console.WriteLine("Semester: 4th Semester");
        }

        static void Main(string[] args)
        {
            StudentInfo student;

            student = DisplayName;
            student += DisplayCourse;
            student += DisplaySemester;

            Console.WriteLine("--- Student Information ---");
            student();

            Console.ReadLine();
        }
    }
}
