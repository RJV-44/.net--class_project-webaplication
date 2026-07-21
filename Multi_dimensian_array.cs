using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Multi_dimensian_array
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            int sum = 0;
            int avg = 0;
            int min = arr[0, 0];
            int Max = arr[0, 0];
            Console.WriteLine("Enter 6 elements:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Enter element: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i, j];
                    avg = sum / (arr.GetLength(0) * arr.GetLength(1));
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                    if (arr[i, j] > Max)
                    {
                        Max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Minimum Element: " + min);
            Console.WriteLine("Maximum Element: " + Max);


        }
    }
}
