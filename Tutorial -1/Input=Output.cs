using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Input_Output
    {
        static void Main(string[] args)
        {
            String Name;
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);
        }
    }
}
