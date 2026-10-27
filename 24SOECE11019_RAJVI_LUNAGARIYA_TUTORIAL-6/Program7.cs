
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program7
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.ReadLine();
        }
    }
}
