using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXE13
    {
        static void Main()
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                amount = amount % note;

                Console.WriteLine("Notes of Rs." + note + " = " + count);
            }
        }

    }
}
