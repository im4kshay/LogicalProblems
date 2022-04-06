using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    class SimulateStopWatch
    {
        public static void GetElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CouponNumbers.CheckCouponNumbers();
            stopwatch.Stop();
            Console.WriteLine("\n Elapsed time to get distinct coupons is: " + stopwatch.ElapsedMilliseconds);
        }
    }
}
