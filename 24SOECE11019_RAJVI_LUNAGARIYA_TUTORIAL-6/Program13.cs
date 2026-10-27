
using System;
using System.Threading;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program13
    {
        static void DisplayNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number: " + i);
                Thread.Sleep(100);
            }
        }

        static void DisplayAlphabets()
        {
            for (char ch = 'A'; ch <= 'J'; ch++)
            {
                Console.WriteLine("Alphabet: " + ch);
                Thread.Sleep(100);
            }
        }

        static void DisplayMessage()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hello! This is a separate thread.");
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayNumbers);
            Thread t2 = new Thread(DisplayAlphabets);
            Thread t3 = new Thread(DisplayMessage);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("All threads completed.");

            Console.ReadLine();
        }
    }
}
