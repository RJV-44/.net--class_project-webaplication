using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class Desending_order
    {
        static void Main()
        {
            int[] arr = { 10, 25, 5, 40, 15 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Array in descending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
