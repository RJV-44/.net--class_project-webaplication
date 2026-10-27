using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;

            // Input 5 elements
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            // Calculate sum
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }

    }
}
