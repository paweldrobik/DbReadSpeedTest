using DbReadSpeedTest.Model.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DbReadSpeedTest
{
    class OrmEF
    {
        public void Result()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var context = new NorthwindContext()) 
            {
                var details = context.OrderDetails;
            }
            stopwatch.Stop();
            Console.WriteLine($"OrmEF: {stopwatch.Elapsed}");
        }
    }
}
