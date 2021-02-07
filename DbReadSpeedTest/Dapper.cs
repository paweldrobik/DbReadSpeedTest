using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace DbReadSpeedTest
{
    class Dapper
    {
        public void Result(string connectionString, string queryString)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var connection = new SqlConnection(connectionString))
            {
                var orderDetail = connection.Query(queryString);              
            }
            stopwatch.Stop();
            Console.WriteLine($"Dapper: {stopwatch.Elapsed}");
        }
    }
}
