using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    

    class MyClient
    {
        public static void Main()
        {
            try
            {
                int x = 0;

                // This causes DivideByZeroException
                int div = 100 / x;

                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                // Handle divide-by-zero error
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                // This block always executes
                Console.WriteLine("Finally block executed.");
            }

            Console.ReadKey();
        }
    }
}
