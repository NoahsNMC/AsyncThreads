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
            double factorial1, factorial2;

            Console.WriteLine("Demonstration of Asynchronous Operations");

            Console.WriteLine();

            Console.WriteLine("Press any key to calculate 20! and 30!.");
            Console.ReadKey();
            Console.WriteLine("Calculating");


            Task<double> factorialTask1 = GetFactorialAsync(20);
            factorial1 = factorialTask1.Result;
            Task<double> factorialTask2 = GetFactorialAsync(30);
            factorial2 = factorialTask2.Result;

            Console.WriteLine($"20! = {factorial1}");
            Console.WriteLine($"30! = {factorial2}");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static double Factorial(double operand)
        {
            if (operand != 1)
            {
                operand = operand * Factorial(operand - 1);
            }

            Thread.Sleep(100);

            return (operand);
        }

        static async Task<double> GetFactorialAsync(int i)
        {
            double factorial = await Task.Run(() => Factorial(i));

            return factorial;
        }
    }
}
