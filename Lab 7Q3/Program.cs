using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"total number of instances are : {Counter.Getc()}");
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Counter c3 = new Counter();

            Console.WriteLine($"Total number of instances now are :{Counter.Getc()} ");
           
        
        }
    }
}
