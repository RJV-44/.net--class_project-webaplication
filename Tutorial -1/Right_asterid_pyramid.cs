using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Right_asterid_pyramid
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Tutorial__1
    {
        internal class Right_asterid_pyramid
        {
            static void Main(string[] args)
            {
                int n, num;
                int term = 0, sum = 0;

                Console.Write("Input the number of terms: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input number: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                for (int i = 1; i <= n; i++)
                {
                    term = term * 10 + num;
                    sum = sum + term;

                    Console.Write(term);

                    if (i < n)
                        Console.Write(" + ");
                }

                Console.WriteLine();
                Console.WriteLine("The Sum is: " + sum);


            }
        }
    }

}
    }
}
