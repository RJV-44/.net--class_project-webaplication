using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class Short_array
    {
        public static void Main(string[] args)
        {
            short[] arr = new short[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ":");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();



        }
    }
}

