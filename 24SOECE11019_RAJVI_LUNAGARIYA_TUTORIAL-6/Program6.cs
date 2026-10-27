
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program6
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Division Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }

            Console.ReadLine();
        }
    }
}
