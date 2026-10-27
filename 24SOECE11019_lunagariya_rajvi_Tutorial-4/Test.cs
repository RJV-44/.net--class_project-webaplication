using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    abstract class Test
    {
        // Protected so derived classes can access it
        protected int a;

        // Abstract method must be protected/public
        public abstract void A();
    }

    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");

            // Increase the value of a
            base.a++;
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");

            // Decrease the value of a
            base.a--;
        }
    }

    class Program3
    {
        static void Main()
        {
            // Reference Example1 through Test type
            Test test1 = new Example1();
            test1.A();

            // Reference Example2 through Test type
            Test test2 = new Example2();
            test2.A();

            Console.ReadKey();
        }
    }
}
