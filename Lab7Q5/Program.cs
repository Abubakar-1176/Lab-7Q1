using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1 = 10;
            double n2 = 5;

            Console.WriteLine($"Addition is : {Math.add(n1, n2)}");
            Console.WriteLine($"Multiplication is : {Math.mult(n1, n2)}");
            Console.WriteLine($"Devition is : {Math.devide(n1, n2)}");
            Console.WriteLine($"Subtraction is : {Math.Sub(n1, n2)}");
            Console.WriteLine($"Devition is : {Math.devide(5, 0)}");
        
    }
    }
}
