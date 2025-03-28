using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The total accounts are : {Account.get()}");

            Account A1 = new Account("Bank Alfalah", 1500);
            Account A2 = new Account("Bank UBL", 1000);
            Account A3 = new Account("Bank HBL", 5500);
            A1.disp();
            A2.disp();
            A3.disp();
            A1.withdraw(100);
            A1.disp();
            A1.deposit(1000);

            Console.WriteLine($"\nThe total accounts are : {Account.get()}");
        }
    }
}
