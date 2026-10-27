
using System;
using System.Collections.Generic;
using System.Linq;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program11
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                15, 8, 3, 12, 6, 21, 10, 4, 18
            };

            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              orderby n ascending
                              select n;

            Console.WriteLine("Even numbers in ascending order:");

            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
