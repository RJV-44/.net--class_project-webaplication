using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Table
    {
        static void Main(string[] args)
        {
            int num1, res, i;

            Console.Write("Enter a Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1;

            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++;
            }

            Console.ReadLine();
        }


    }
}

