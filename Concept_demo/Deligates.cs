using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_demo
{

    delegate void mydeligate(int x, int y);
    internal class Deligates
    {
        public static void add(int x , int y)
        {
            Console.WriteLine(x + ", " + y);
            Console.WriteLine("sum:" + (x+y));
        }
        public static void sub(int x , int y) 
        {
            Console.WriteLine(x + ", " + y);
            Console.WriteLine("sub:" + (x-y));
        }
        public static void mul(int x , int y) 
        {
            Console.WriteLine(x + ", " + y);
            Console.WriteLine("mul:" + (x*y));
        }
        public static void div(int x , int y) 
        {
            Console.WriteLine(x + ", " + y);
            Console.WriteLine("div:" + (x / y));
        }
        public static void Main(string[] args)
        {

            mydeligate o = new mydeligate(add);
            o += new mydeligate(sub);
            o += mul;
            o += div;
            o(5, 15);
            
           

        }
    }
}
