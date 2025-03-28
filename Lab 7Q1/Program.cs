using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.WriteLine("|--------------------------- ABUBAKAR ZAFAR CAR SHOP ---------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------|");
            Car unknownCar = new Car();
            unknownCar.DisplayInfo();

            Car myCar = new Car("Toyota", "Corolla", 2020);
            myCar.DisplayInfo();

            myCar.Accelerate(50);
            Console.WriteLine("After accelerating by 50 :");
            myCar.DisplayInfo();

            Car copiedCar = new Car(myCar);
            Console.WriteLine("\nCopied car:");
            copiedCar.DisplayInfo();
        }
    }
}
