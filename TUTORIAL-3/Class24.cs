using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
       class Class24
    {
        static void Main()
        {

            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");


            Console.WriteLine("enter password:"); string password = Console.ReadLine();

            password = password.Trim();

            Console.WriteLine("Password Details");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Password Length: " + password.Length);
            if (password.Length < 8)
            {
                Console.WriteLine("Password is too short. It should be at least 8 characters long.");
            }
            else
            {
                Console.WriteLine("Password length is  valid.");

                if (password.Contains("@") || password.Contains("#") ||
                    password.Contains("$"))
                {
                    Console.WriteLine("special character : Available.");
                }
                else
                {
                    Console.WriteLine("special character : not  Available.");
                }

                Console.WriteLine("Uppercase password: " + password.ToUpper());

                Console.WriteLine("Lowercase password: " + password.ToLower());

                string modifiedPassword = password.Replace("@", "#");

                Console.WriteLine("Modified Password: " + modifiedPassword);
            }

            Console.ReadLine();
        }
    }
}
