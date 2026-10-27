using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Upper_later
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("Output: " + upperName);

            Console.ReadLine();
        }   

    }
}
