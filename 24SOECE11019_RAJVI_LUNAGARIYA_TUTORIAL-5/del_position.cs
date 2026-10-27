using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{
    internal class del_position
    {
        static void Main()
        {
            int[] arr = { 10, 25, 5, 40, 15 };
            int position = 2; // Position to delete (0-based index)
            if (position < 0 || position >= arr.Length)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            for (int i = position; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1); // Resize the array to remove the last element
            Console.WriteLine("Array after deleting element at position " + position + ":");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

    }
}
