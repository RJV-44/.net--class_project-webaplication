using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Number_pyramid
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 4;
            int counter = 1; // Counter to keep track of the number to print
            for (i = 1; i <= n; i++)
            {
                // Print leading spaces to center the numbers
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Print numbers with a space after each
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                // Move to the next line after finishing a row
                Console.WriteLine();
            }
        }
    }
}
