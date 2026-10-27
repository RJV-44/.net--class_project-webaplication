
using System;
using System.Threading;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class Program14
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Thread is running...");

            Thread.Sleep(2000);

            Console.WriteLine("Thread task completed.");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(DisplayMessage);

            Console.WriteLine("Thread Created.");
            Console.WriteLine("Thread State: " + t.ThreadState);

            t.Start();

            Console.WriteLine("Thread Started.");
            Console.WriteLine("Thread State: " + t.ThreadState);

            Console.WriteLine("Waiting for thread to complete...");

            t.Join();

            Console.WriteLine("Thread Execution Finished.");
            Console.WriteLine("Thread State: " + t.ThreadState);

            Console.ReadLine();
        }
    }
}
