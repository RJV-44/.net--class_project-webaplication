using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            int avg = 0;
            int min = arr[0];
            int Max = arr[0];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
                avg = sum / arr.Length;

                if (arr[0] < arr[i])
                {
                    min = arr[0];
                    Max = arr[i];
                    i++;
                }
                else
                {
                    min = arr[i];
                    Max = arr[0];
                    i++;
                }
            }

            Console.WriteLine("Array Elements: " + string.Join(" ", arr));
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine("Minimum Element: " + min);
            Console.WriteLine("Maximum Element: " + Max);
        }
    }
}
