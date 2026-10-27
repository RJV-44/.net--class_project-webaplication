using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_project_console
{
    internal class Table
    {
        public static void TB()
        {
            int number;
            int i = 1;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of " + number);

            while (i <= 10)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
                i++;
            }


        }
    }
}
