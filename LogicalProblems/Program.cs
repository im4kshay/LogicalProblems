﻿using System;
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
            Console.WriteLine("\n 1. Fibonacci Series \n");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FibonacciSeries.GetFibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
            Console.ReadLine();
        }
    }
}