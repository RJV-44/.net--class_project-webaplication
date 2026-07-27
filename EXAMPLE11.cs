using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE11
    {

        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of array elements = " + sum);
        }

    }
}
