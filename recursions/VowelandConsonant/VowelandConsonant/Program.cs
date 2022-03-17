using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VowelandConsonant
{
    class Program
    { 
        string text = Console.ReadLine().ToLower();
        static void Main(string[] args)
        {
            Console.WriteLine("[1] No of Vowels");
            Console.WriteLine("[2] No of Consonants");
            Console.Write("Select Function: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            if (choice == 1)
            {
                vowel();
            }
            else if (choice == 2)
            {
                consonant();
            }
            else 
            {
                Console.WriteLine("Select from functions 1 and 2");
            }

            Console.WriteLine("--------------------------------------------------");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Created by: Gales, Christian Charles P. BSIT-1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Instructor: Mr. Nesty Gordo");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static void vowel()
        {
            var vowel = new[] { 'a', 'e', 'i', 'o', 'u' };
            Console.Write("Enter a string: ");
            var text = Console.ReadLine().ToLower();
            var cvowel = text.Count(x => vowel.Contains(x));

            Console.WriteLine("No of vowels : {0}", cvowel);
    
        }
        private static void consonant()
        {
            var cons = new[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 
            's', 't', 'v', 'w', 'x', 'y', 'z'};
            Console.Write("Enter a string: ");
            var text = Console.ReadLine().ToLower();
            var ccons = text.Count(x => cons.Contains(x));

            Console.WriteLine("No of consonants : {0}", ccons);
        
        }
        
    }
}
