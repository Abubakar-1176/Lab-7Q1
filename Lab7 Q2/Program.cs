using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1);
            Person person2 = new Person("Abubakar", 30, "Madna town fsd");
            Console.WriteLine(person2);
            Person person3 = new Person(person2);
            Console.WriteLine(person3);
            person2.ChangeAddress("jaranwala 12434");
            Console.WriteLine($"After address change: {person2}");
        }
    
}       
    
}
