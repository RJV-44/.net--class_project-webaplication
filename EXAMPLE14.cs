using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE14
    {

        static void Main()
        {
            Console.Write("Input the marks obtained in Maths : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int total = maths + physics + chemistry;
            int mathPhyTotal = maths + physics;

            if (maths >= 65 &&
                physics >= 55 &&
                chemistry >= 50 &&
                (total >= 180 || mathPhyTotal >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }

    }
}
