using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    class X
    {
        // Virtual methods in base class
        public virtual void F()
        {
            Console.WriteLine("X.F");
        }

        public virtual void F2()
        {
            Console.WriteLine("X.F2");
        }
    }

    class Y : X
    {
        // Sealed method cannot be overridden further
        public sealed override void F()
        {
            Console.WriteLine("Y.F");
        }

        // F2 is not sealed, so it can be overridden by Z
        public override void F2()
        {
            Console.WriteLine("Y.F2");
        }
    }

    class Z : Y
    {
        // We CANNOT override F here because Y.F() is sealed.

        // Overriding F2
        public override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }

    class SealedMethodTest
    {
        static void Main()
        {
            // Object of X
            X Obj1 = new X();

            Obj1.F();
            Obj1.F2();

            // Object of Y
            Y Obj2 = new Y();

            Obj2.F();
            Obj2.F2();

            // Object of Z
            Z Obj3 = new Z();

            // F() comes from Y because it is sealed in Y
            Obj3.F();

            // F2() is overridden in Z
            Obj3.F2();

            Console.ReadKey();
        }
    }
}
