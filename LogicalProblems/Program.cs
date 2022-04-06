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
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n 4. Reverse Number \n 5. Coupon Numbers \n 6. Simulate Stop Watch" +
                "\n 7. Notes Vending Machine \n 8. Day of Week \n 9. Temperature Conversion \n 10. Monthly Payment \n 11. Sqrt \n 12. To Binary \n 13. Swap Nibbles \n");
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
                case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                case 5:
                    CouponNumbers.CheckCouponNumbers();
                    break;
                case 6:
                    SimulateStopWatch.GetElapsedTime();
                    break;
                case 7:
                    NotesVendingMachine.GetNotes();
                    break;
                case 8:
                    DayOfWeek.FindDayOfWeek();
                    break;
                case 9:
                    TemperatureConversion.ConvertTemp();
                    break;
                case 10:
                    MonthlyPayment.GetMonthlyPayment();
                    break;
                case 11:
                    Console.WriteLine("Enter a non negative number: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double answer = SquareRoot.GetSqrtOfNonNegativeNum(c);
                    Console.WriteLine(answer);
                    break;
                case 12:
                    ToBinary.ConvertToBinary();
                    Console.ReadLine();
                    break;
                case 13:
                    SwapNibblesAndResult.Swap_GetResultantNumber();
                    break;
                default:
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
            Console.ReadLine();
        }
    }
}
