using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Even_odd
    {
        static void Main(String[] args)
        {
            int size;
            int even = 0;
            int odd = 0;
            int negative = 0;
            int positive = 0;
            Console.WriteLine("enter an size :");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter a number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + "Even number");
                    even++;

                }
                else
                {
                    Console.WriteLine(arr[i] + "odd number");
                    odd++;

                }
                if (arr[i] < 0)
                {
                    Console.WriteLine("Negative number");
                    negative++;
                }
                else
                {
                    Console.WriteLine("Positive number");
                    positive++;

                }
                Console.WriteLine("Array Elements: " + string.Join(" ", arr));
                Console.WriteLine("Total even numbers: " + even);
                Console.WriteLine("Total odd numbers: " + odd);

            }
        }
    }
}

