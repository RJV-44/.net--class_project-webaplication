using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_3._1
{
    internal class sum_average
    {

    
        static void Main()
        {

            Console.WriteLine("Rajvi lunagaruya");
            Console.WriteLine("enroll no : 24SOECE11019");
            Console.Write("Enter the number of elements : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

           
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            double average = (double)sum / n;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }
    }
}

