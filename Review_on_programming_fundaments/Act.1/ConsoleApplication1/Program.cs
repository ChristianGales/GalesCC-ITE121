using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Firstame: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Your Lastname: ");
            string lname = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Please enter a numeric value as your age: ");   
            }
            age = 2022 - age;
            Console.WriteLine("" +fname+ " " + lname+ " was born on " +age );
      
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Christian Charles Gales -BSIT- 1");
            Console.ReadKey();
           

        }
    }
}
