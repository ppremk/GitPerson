using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNs;

namespace PersonTest
{
    class Program
    {
        static void Main()
        {
            Person customer = new Person();
            customer.FirstName = "Prem";
            customer.LastName = "Kumar";

            string FullName = customer.GetFullName("Prem ", "Kumar");

            // Console.WriteLine(customer.FirstName);
            Console.WriteLine(FullName);
            Console.ReadLine();

        }
    }
}
