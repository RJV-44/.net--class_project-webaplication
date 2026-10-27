
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    delegate double Calculate(double a, double b);

    class Program3
    {
        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Subtraction(double a, double b)
        {
            return a - b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculate calc;

            calc = Addition;
            Console.WriteLine("Addition: " + calc(num1, num2));

            calc = Subtraction;
            Console.WriteLine("Subtraction: " + calc(num1, num2));

            calc = Multiplication;
            Console.WriteLine("Multiplication: " + calc(num1, num2));

            if (num2 != 0)
            {
                calc = Division;
                Console.WriteLine("Division: " + calc(num1, num2));
            }
            else
            {
                Console.WriteLine("Division by zero is not possible.");
            }

            Console.ReadLine();
        }
    }
}
