using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_project_console
{
    internal class Aadition
    {
        public static void Add()
        {
            int num1, num2,num3 ,sum;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num3= Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is: " + sum);
        }
    }
}
