using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Q5
{
    internal class Math
    {
        public static double add(double x, double y)
        {
            return x + y;
        }

        public static double mult(double x, double y)
        {
            return x * y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double devide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine($"\nError !!");
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}
