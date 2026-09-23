using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class clock1

    {
        private int hour; private int min; private int sec;
        //no argument constructor 
        public clock1()
        {
            hour = 12; min = 0; sec = 0;
        }          //parameterized constructor 
        public clock1(int h, int m, int s)
        {
            hour = h; min = m; sec = s;
        }

        public void IncrementTime()
        {
            sec++;

            if (sec == 60)
            {
                sec = 0; min++;

                if (min == 60)
                {
                    min = 0; hour++;

                    if (hour == 24) hour = 0;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }

    }


    class Class9
    {
        static void Main()
        {

            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            clock1 c = new clock1();
            Console.WriteLine("Current Time:"); c.Display();

            c.IncrementTime();
            Console.WriteLine("After increment:"); c.Display();
            Console.Read();
        }
    }

}
