using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE7
    {

        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }

    class TestRef
    {
        static void Main(string[] args)
        {
            EXAMPLE7 n = new EXAMPLE7();

            int a, b;

            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }

    }
}
