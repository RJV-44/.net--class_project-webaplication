using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class fibonaki
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a + " " + b + " ");
            for (int i = 2; i <= 9; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");

                a = b;
                b = c;

            }
        }
          
    }
}
