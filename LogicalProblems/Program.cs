using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program");
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FibonacciSeries.GetFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.GetPrimeNumbers();
                    break;
                default:
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
            Console.ReadLine();
        }
    }
}
