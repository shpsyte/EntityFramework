using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GlobalFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyContext();
            Console.WriteLine("++++----------------------+++++");
            Console.WriteLine("Global Filter Test!");
            Console.WriteLine("++++----------------------+++++");


            Console.WriteLine("\n");
            Console.WriteLine("No Filter ");

            var customer = db.Customer.ToList();
            var customerli = db.Customer.IgnoreQueryFilters().ToList();

 

            foreach (var item in customerli)
            {
                Console.Write($" Name : { item.Name }   \n");
            }


            Console.ReadLine();

        }
    }
}
