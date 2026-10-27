using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    

    // User-defined exception class
    class Mxception : Exception
    {
        // Constructor of custom exception
        public Mxception(string str) : base(str)
        {
            Console.WriteLine("User defined exception");
        }
    }

    class MyClient1
    {
        public static void Main()
        {
            try
            {
                // Throw user-defined exception
                throw new Mxception("my exception generated.");
            }
            catch (Exception e)
            {
                // Display the exception message
                Console.WriteLine("Exception caught here: " + e.Message);
            }

            // This statement executes after the exception is handled
            Console.WriteLine("LAST STATEMENT");

            Console.ReadKey();
        }
    }
}
