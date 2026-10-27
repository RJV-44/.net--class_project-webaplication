
using System;
using System.Collections.Generic;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program10
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int> { 45, 75, 60, 35, 90, 50, 85 };

            Console.WriteLine("Student Marks Greater Than 50:");

            marks.FindAll(m => m > 50)
                 .ForEach(m => Console.WriteLine(m));

            Console.ReadLine();
        }
    }
}
