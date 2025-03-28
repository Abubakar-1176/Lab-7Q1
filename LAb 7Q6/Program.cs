using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_7Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Heloo world of c#";
            Console.WriteLine($"Reverse : {@string.rev(a)}");
            Console.WriteLine($"Upper case : {@string.upper(a)}");
            Console.WriteLine($"number of characters  : {@string.count(a)}");

        }
    }
}



