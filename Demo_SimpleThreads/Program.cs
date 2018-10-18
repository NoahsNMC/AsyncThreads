using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_SimpleThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader("Threading Demonstration");
            DisplayContinuePrompt();

            //SimpleSleepCurrentThread(2);
            CountingWithNewThread();

            DisplayContinuePrompt();
        }

        static void SimpleSleepCurrentThread(int seconds)
        {
            DisplayHeader("Simple Sleep Current Thread");
            Console.WriteLine($"Press any key to sleep the application for {seconds} seconds.");
            Console.ReadKey();

            Console.WriteLine("The application is asleep.");
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("The application has resumed.");

            CountingWithNewThread();

            DisplayContinuePrompt();
        }

        static void CountingWithNewThread()
        {
            DisplayHeader("Counting with a New Thread");
            Console.WriteLine($"Press any key to continue.");
            Console.ReadKey();

            //
            // create new threads
            //
            Thread thread1 = new Thread(PrintCountingNumbers);
            thread1.Start();
            //thread1.Join();
            //Thread thread2 = new Thread(PrintCountingNumbers);
            //thread2.Start();


            //thread2.Join();

            DisplayContinuePrompt();
        }

        static void PrintCountingNumbers()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i} ");
            }
        }

        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
