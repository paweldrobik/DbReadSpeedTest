using DbReadSpeedTest.Model.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DbReadSpeedTest
{
    class RawSQL
    {
        public void Result()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.OrderDetails.FromSqlRaw("Select * from [Order Details]").ToList();
            };
            stopwatch.Stop();

            Console.WriteLine($"Raw: {stopwatch.Elapsed}");
        }
    }
}
