using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class Gender
    {
        static void Main(string[] args)
        {
            String Name;
            Char Gender;
            Console.WriteLine("Enter your gender (M/F): ");
            Name = Console.ReadLine();
            Gender = Convert.ToChar(Console.ReadLine());

            if (Gender == 'M' || Gender == 'm')
            {
                Console.WriteLine("Hello Mr. " + Name);
            }
            else if (Gender == 'F' || Gender == 'f')
            { Console.WriteLine("Hello Ms. " + Name);
            }
            else
            {
                Console.WriteLine("invalid Gender");
            }
        }
    }
}
