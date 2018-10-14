using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_AsycOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of Asynchronous Operations");

            Console.WriteLine();

            Console.WriteLine("Press any key to list factorials up to 20.");
            Console.ReadKey();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Factorial(i));
            }

            Console.ReadKey();
        }

        static double Factorial(double operand)
        {
            if (operand != 1)
            {
                operand = operand * Factorial(operand - 1);
            }

            Thread.Sleep(75);

            return (operand);
        }
    }
}
