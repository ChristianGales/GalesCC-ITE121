using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class recursionvowel
{
    public static int isVowel(char ch)
    {
        ch = char.ToUpper(ch);
        if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public static int countVowels(string str, int n)
    {
        if (n == 1)
        {
            return isVowel(str[n - 1]);
        }
        return countVowels(str, n - 1) + isVowel(str[n - 1]);
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        String str;
        str = Console.ReadLine();
        Console.WriteLine("Number of Vowels: " + countVowels(str, str.Length));

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        System.Threading.Thread.Sleep(1500);
        Console.WriteLine("Created by: Gales, Christian Charles P. BSIT-1");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Instructor: Mr. Nesty Gordo");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();

    }
}
