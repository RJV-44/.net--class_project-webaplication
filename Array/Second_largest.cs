using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Second_largest
    {
        static void Main(string[] args)
        {
            int size;
            int max = 0;
            int Second_largest = 0;
            Console.WriteLine("Enter the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number:");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] > max)
                {
                    Second_largest = max;
                    max = arr[i];
                }
                else if (arr[i] > Second_largest && arr[i] != max)
                {
                    Second_largest = arr[i];
                }



            }
            Console.WriteLine("The second largest number is: " + Second_largest);

        }
    }
}
