
using System;

namespace Concept_demo
{
    internal class constructor_example
    {
        class a
        {
            public a()
            {
                Console.WriteLine("form a");
            }
        }

        class b : a
        {
            public b()
            {
                Console.WriteLine("form b");
            }
        }

        class c : b
        {
            public c(int x = 2)
            {


            }

            static void Main(string[] args)
            {
                c b1 = new c();
                Console.ReadLine();
            }
        }
    }
}
