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
            double factorial1, factorial2, factorial3;

            Console.WriteLine("Demonstration of Asynchronous Operations");

            Console.WriteLine();

            Console.WriteLine("Press any key to calculate 20!, 30!, and 50!.");
            Console.ReadKey();
            Console.WriteLine("Calculating");

            //factorial1 = Factorial(20);
            //factorial2 = Factorial(30);
            //factorial3 = Factorial(50);

            Task<double> factorialTask1 = GetFactorialAsync(20);
            Task<double> factorialTask2 = GetFactorialAsync(30);
            Task<double> factorialTask3 = GetFactorialAsync(50);
            factorial1 = factorialTask1.Result;
            factorial2 = factorialTask2.Result;
            factorial3 = factorialTask3.Result;

            Console.WriteLine($"20! = {factorial1}");
            Console.WriteLine($"30! = {factorial2}");
            Console.WriteLine($"50! = {factorial3}");

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
