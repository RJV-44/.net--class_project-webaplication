using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class AEstric_pyramid
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces to center the stars
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars with a space after each
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                // Move to the next line after finishing a row
                Console.WriteLine();
            }
        }
    }
}
