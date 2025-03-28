using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7Q4
{
    internal class Account
    {
        private string name { get; set; }
        private int balance { get; set; }

        static int counter;

        public Account(string name, int bal)
        {
            this.name = name;
            this.balance = bal;
            counter++;
        }

        public void deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"\nbalance is add sucessfully \n new balance is : {balance}");
        }

        public void withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine($"\nbalance is deducted sucessfully \n new balance is : {balance}");
        }

        public static int get()
        {
            return counter;
        }

        public void disp()
        {
            Console.WriteLine($"\nName = {name} \nBalnce = {balance} ");
        }
    }
}