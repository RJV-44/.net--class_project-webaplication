using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE12
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int found = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }

    }
}
