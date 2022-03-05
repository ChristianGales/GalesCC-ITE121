using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)

        {
            //Gales, Christian Charles P. BSIT-1

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string print;

            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    print = "FizzBuzz";
                else if (i % 3 == 0)
                    print = "Fizz";
                else if (i % 5 == 0)
                    print = "Buzz";
                else
                    print = i.ToString();

                Console.WriteLine(print);

            }
                Console.ReadKey();
        }
    }
}
