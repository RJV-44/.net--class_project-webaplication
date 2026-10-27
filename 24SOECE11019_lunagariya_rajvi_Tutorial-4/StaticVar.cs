using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    class StaticVar
    {
        // Static variable
        public static int num;

        // Constructor
        public StaticVar()
        {
            num++;
        }

        // Method to return the value of static variable
        public static int getNum()
        {
            return num;
        }
    }

    class StaticTester
    {
        static void Main(string[] args)
        {
            // Creating three objects
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            StaticVar s3 = new StaticVar();

            // Display the value of static variable
            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            Console.ReadKey();
        }
    }
}
