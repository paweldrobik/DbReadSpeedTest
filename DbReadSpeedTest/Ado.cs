using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace DbReadSpeedTest
{
    class Ado
    {
        public void Result(string connectionString, string queryString)
        {
            Stopwatch stopwatch = new Stopwatch();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    stopwatch.Start();
                    connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while(sqlDataReader.Read())
                    {

                    }
                    sqlDataReader.Close();
                    stopwatch.Stop();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Ado speed result: {stopwatch.Elapsed}");
        }

    }
}
