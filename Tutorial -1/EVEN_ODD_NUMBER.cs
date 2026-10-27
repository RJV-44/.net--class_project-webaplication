using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class EVEN_ODD_NUMBER
    {
        static void Main( string[] args)
        {
            int n;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(" is an even number.", n);

            }
            else
            {
                Console.WriteLine("is an odd number .", n);
            }
        }
    }
}
