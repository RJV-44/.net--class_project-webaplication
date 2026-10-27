
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_5
{

    interface count_duplicate
    {
        public static void Main()
        {
            int[] arr = { 10, 20, 10, 30, 20, 40, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count > 1)
                    Console.WriteLine(arr[i] + " occurs " + count + "times");
            }
            Console.Read();
        }
    }
}
