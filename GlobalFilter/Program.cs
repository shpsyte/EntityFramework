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
            Console.WriteLine("Filter Enabled defatult");

            var customer = db.Customer.ToList();
            var customerli = db.Customer.IgnoreQueryFilters().ToList();


            foreach (var item in customer)
            {
                Console.Write($" Name : { item.Name }  Active:  { item.Active} \n");
            }

            Console.WriteLine("\n");
            Console.WriteLine("No Filter");

            foreach (var item in customerli)
            {
                Console.Write($" Name : { item.Name }  Active:  { item.Active} \n");
            }


            Console.ReadLine();

        }
    }
}
