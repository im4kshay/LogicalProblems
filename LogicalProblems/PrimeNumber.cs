using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    class PrimeNumber
    {
        public static void GetPrimeNumbers()
        {
            Console.WriteLine("Enter the range to print prime numbers within that range (a to b): ");
            Console.WriteLine("Enter the value of starting number (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of end number (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int prime = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = 0;
                        break;
                    }
                }
                if (prime == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
