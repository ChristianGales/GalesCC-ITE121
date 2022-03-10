using System;
using System.Collections.Generic;
using System.Linq;
namespace Array_Exercise
{
    public class Program
    {    
        
        private static bool IsNumber(string str)
        {
            foreach (char ch in str)
                if (!(ch <= '9' && ch >= '0'))
                    return false;

            return true;
        }

        private static void PrintArray(List<int> Numbers)
        {
            foreach (int i in Numbers)
                Console.Write(i + ", ");
        }

        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter array elements (Enter non-numeric value to stop)");

            List<int> array = new List<int>();
            for (; ; )
            {
                string str = Console.ReadLine();

                if (!IsNumber(str)) break;
                array.Add(Convert.ToInt32(str));
            }

            //menu
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("[1] Delete Elements");
            Console.WriteLine("[2] Show Frequency");
            Console.WriteLine("[3] Print Unique Elements");
            Console.WriteLine("[4] Count Dulicated Elements");
            Console.WriteLine("[5] Delete Dublicated Elements");
            Console.WriteLine("--------------------------------------------------");
            
            //functions
            Console.Write("Select Function: ");
            int function = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            if (function == 1)
            {
                 Console.Write("Enter index: ");
                 array.RemoveAt(Convert.ToInt32(Console.ReadLine()));

                 Console.WriteLine("The remaining elements are now: ");
                 PrintArray(array);

                 Console.WriteLine();
            }
            else if (function == 2)
            {
                 Console.WriteLine("Elements");
                 foreach (var elem in array.GroupBy(i => i).ToDictionary(x => x.Key, x => x.Count()))
                 
                 Console.WriteLine("{0} =  is printed {1} time(s)", elem.Key, elem.Value);
                 Console.WriteLine();
            }

            else if (function == 3)
            {
                 Console.WriteLine("All Unique Elements");
                 PrintArray(array.Distinct().ToList());

                 Console.WriteLine();
            }

            else if (function == 4)
            {
                 Console.WriteLine("Total numbers of duplicated elements is  " + array.GroupBy(_ => _).Where(_ => _.Count() > 1).Sum(_ => _.Count()));

                 Console.WriteLine();
            }

            else if (function == 5)
            {
                Console.WriteLine("Delete all duplicated elements");
                array = array.Distinct().ToList();
                PrintArray(array);

                Console.WriteLine();
            }

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Created by: Gales, Christian Charles P. BSIT-1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Instructor: Mr. Nesty Gordo");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); 
        }

    }
}
