using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class DIMOND_ASTRIG
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            Console.WriteLine("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            // Upper half of the diamond
            for (i = 1; i <= n; i++)
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Lower half of the diamond
            for (i = n - 1; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
