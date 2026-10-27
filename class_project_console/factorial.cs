using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_project_console
{
    internal class Factorial
    {
        public static void Fact()
        {
            int number, i, fact = 1;
            Console.WriteLine("enter the number: ");

            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + fact);
            Console.ReadLine();
        }
    }
}