using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    sealed class A1
    {
        // Public data members
        public int x;
        public int y;
    }

    class SealedTest2
    {
        static void Main()
        {
            // Create an object of sealed class A
            A1 sc = new A1();

            // Assign values
            sc.x = 110;
            sc.y = 150;

            // Display values
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

            Console.ReadKey();
        }
    }
}
