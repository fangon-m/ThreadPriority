using System;
using System.Threading;

namespace ThreadPriorityDemo
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
