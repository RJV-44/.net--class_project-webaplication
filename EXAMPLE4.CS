using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE4
    {
        static void Main(string[] args)
        {
            // Integer data type
            int A, B;

            Console.Write("Enter first number (A): ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operators ---");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + (A / B));
            Console.WriteLine("A % B = " + (A % B));

            // Relational Operators
            Console.WriteLine("\n--- Relational Operators ---");
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B : " + (A > B));
            Console.WriteLine("A < B : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            // Logical Operators
            Console.WriteLine("\n--- Logical Operators ---");
            Console.WriteLine("(A > 0 && B > 0) : " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) : " + (A > 0 || B > 0));
            Console.WriteLine("!(A > B) : " + !(A > B));

            // Assignment Operators
            Console.WriteLine("\n--- Assignment Operators ---");
            int C = A;
            C += B;
            Console.WriteLine("C += B : " + C);

            C = A;
            C -= B;
            Console.WriteLine("C -= B : " + C);

            // Increment / Decrement
            Console.WriteLine("\n--- Increment / Decrement ---");
            Console.WriteLine("++A = " + (++A));
            Console.WriteLine("--B = " + (--B));

            // Different Data Types
            Console.WriteLine("\n--- Different Data Types ---");
            double d = 15.75;
            float f = 8.5f;
            char ch = 'X';
            bool flag = true;
            string name = "C# Programming";

            Console.WriteLine("Double : " + d);
            Console.WriteLine("Float : " + f);
            Console.WriteLine("Char : " + ch);
            Console.WriteLine("Boolean : " + flag);
            Console.WriteLine("String : " + name);

            Console.ReadLine();
        }
    }

}

