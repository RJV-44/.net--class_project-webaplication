using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE9CS
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int size = 2 * N + 2;
            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int xor = 0;

            for (int i = 0; i < size; i++)
            {
                xor ^= arr[i];
            }

            int setBit = xor & (-xor);

            int num1 = 0, num2 = 0;

            for (int i = 0; i < size; i++)
            {
                if ((arr[i] & setBit) != 0)
                    num1 ^= arr[i];
                else
                    num2 ^= arr[i];
            }

            if (num1 < num2)
                Console.WriteLine("Output: " + num1 + " " + num2);
            else
                Console.WriteLine("Output: " + num2 + " " + num1);
        }

    }
}
