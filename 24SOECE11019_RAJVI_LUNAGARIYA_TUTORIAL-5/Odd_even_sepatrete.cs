using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class Odd_even_sepatrete
    {
        static void Main()
        {
            int[] arr = { 10, 25, 5, 40, 15 };
            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];
            int o = 0, e = 0;
            Console.WriteLine("Odd numbers in the array:");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    even[o] = num; 
                    o++;
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("Even numbers in the array:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    even[e] = num;
                    e++;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
