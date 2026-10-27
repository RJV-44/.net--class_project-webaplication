using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE8
    {
        public int getValues(out int x, out int y, out int z)
        {
            int sum;

            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());

            sum = x + y + z;

            return sum;
        }
    }

    class TestOut
    {
        static void Main(string[] args)
        {
            EXAMPLE8 n = new EXAMPLE8();

            int a, b, c, sum;

            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);
        }
    }

}

