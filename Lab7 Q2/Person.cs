using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Q2
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public Person() : this("Unknown", 0, "Not specified") 
        {
         }
        public Person(string name, int age) : this(name, age, "Not specified") 
        {
          }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public Person(Person otherPerson)
        {
            Name = otherPerson.Name;
            Age = otherPerson.Age;
            Address = otherPerson.Address;
        }
        public void ChangeAddress(string newAddress)
        {
            if (newAddress == null)
            {
                return;
            }
            Address = newAddress;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
}
