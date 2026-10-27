using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_project_console
{
    internal class Class2
    {
        public static void Even_Odd_1()
        {
            int number;
            Console.WriteLine("Enter a number: ");

            String str = Console.ReadLine();
            number = Convert.ToInt32(str);

            if (number % 2 == 0)  
            {
                Console.WriteLine(" an even number.");
            }
            else
            {
                Console.WriteLine(" an odd number.");
            }
            Console.ReadLine();

        }
        


    }
}

