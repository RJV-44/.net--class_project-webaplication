using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            //int number, sum = 0, temp, remainder;
            //Console.WriteLine("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //temp = number;
            //while (temp != 0)
            //{
            //    remainder = temp % 10;
            //    sum += remainder * remainder * remainder;
            //    temp /= 10;
            //}
            //if (sum == number)
            //    Console.WriteLine(number + " is an Armstrong number.");
            //else
            //    Console.WriteLine(number + " is not an Armstrong number.");

            int number, original , result = 0, remainder;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;
            while (number = 0)
            {
                remainder = original % 10;
                result += remainder * remainder * remainder;
                original /= 10;
            }
            if (original == result)
            {
                Console.WriteLine(original + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(original + " is not an Armstrong number.");
            }
            Console.ReadLine();

        }
     }
}
