using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class PHONE
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string result = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Output: " + result);
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }

            Console.ReadLine();

        }
    }
}
