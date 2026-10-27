
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Lambda expressions
            Func<int, int, int> addition = (x, y) => x + y;
            Func<int, int, int> multiplication = (x, y) => x * y;
            Func<int, int, int> maximum = (x, y) => x > y ? x : y;

            Console.WriteLine("Addition: " + addition(a, b));
            Console.WriteLine("Multiplication: " + multiplication(a, b));
            Console.WriteLine("Maximum: " + maximum(a, b));

            Console.ReadLine();
        }
    }
}
