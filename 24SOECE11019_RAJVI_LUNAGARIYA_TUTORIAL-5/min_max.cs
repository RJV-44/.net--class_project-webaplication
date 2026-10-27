using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class min_max
    {
        

    
        static void Main()
        {
            int[] arr = { 10, 25, 5, 40, 15 };

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);
        }
    }
}

