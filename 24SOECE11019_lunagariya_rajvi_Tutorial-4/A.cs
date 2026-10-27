using System;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    // Base class
    public class A
    {
        // Constructor of base class
        public A(int value)
        {
            Console.WriteLine("Base constructor A()");
        }
    }

    // Derived class
    public class B : A
    {
        // Constructor of derived class
        // base(value) calls the constructor of class A
        public B(int value) : base(value)
        {
            Console.WriteLine("Derived constructor B()");
        }
    }

    // Main/Driver class
    class Program1
    {
        static void Main()
        {
            // Create object of base class A
            A a = new A(0);

            // Create object of derived class B
            // First A's constructor executes,
            // then B's constructor executes.
            B b = new B(1);

            Console.ReadKey();
        }
    }
}