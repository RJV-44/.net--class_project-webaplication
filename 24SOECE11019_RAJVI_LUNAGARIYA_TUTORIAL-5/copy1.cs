using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class copy1
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr2 = new int[arr1.Length];
            Array.Copy(arr1, arr2, arr1.Length);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadLine();
        }
    }
}
