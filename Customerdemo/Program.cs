using System;

namespace Customerdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer(1);
            cust.orders.Add(new Order());
            cust.orders.Add(new Order());
            cust.promote();

            Console.WriteLine(cust.orders.Count);
        }
    }
}
