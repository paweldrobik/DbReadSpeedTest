using System;

namespace DbReadSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost,1433;Database=Northwind;User=sa;Password=Kaktus456!;Trusted_Connection=False;";
            string commandString = "Select * from [Order Details]";


            Console.WriteLine("Speed test");

            Ado ado = new Ado();
            Dapper dapper = new Dapper();
            OrmEF ormEF = new OrmEF();
            CompiledQuery compiledQuery = new CompiledQuery();
            RawSQL rawSQL = new RawSQL();


            ado.Result(connectionString, commandString);
            ado.Result(connectionString, commandString);
            ado.Result(connectionString, commandString);

            dapper.Result(connectionString, commandString);
            dapper.Result(connectionString, commandString);
            dapper.Result(connectionString, commandString);
            
            ormEF.Result();
            ormEF.Result();
            ormEF.Result();
            
            compiledQuery.Result();
            compiledQuery.Result();
            compiledQuery.Result();
            
            rawSQL.Result();
            rawSQL.Result();
            rawSQL.Result();

            Console.ReadKey();
        }
    }
}
