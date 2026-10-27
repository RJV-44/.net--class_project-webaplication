using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_project_console
{
    internal class Division
    {
        public static void Div()
        {
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                double result = (double)num1 / num2;
                Console.WriteLine("Division of " + num1 + " by " + num2 + " is: " + result);
            }
        }
    }
}
