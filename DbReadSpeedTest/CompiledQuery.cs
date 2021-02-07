using DbReadSpeedTest.Model.DB;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace DbReadSpeedTest
{
    class CompiledQuery 
    {
        public void Result()
        {
            Stopwatch stopwatch = new Stopwatch();
            
            var query = EF.CompileQuery((NorthwindContext db)
                              => (from x in db.OrderDetails
                                  select x));
            stopwatch.Start();
            using (NorthwindContext context = new NorthwindContext())
            {
                var listOrderDetails = query.Invoke(context);
            };
            stopwatch.Stop();

            System.Console.WriteLine($"Compiled query: {stopwatch.Elapsed}");
        }
    }
}
