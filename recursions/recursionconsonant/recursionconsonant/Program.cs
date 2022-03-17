using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class recursionconsonant
{
    static Boolean isConsonant(char ch)
    {
        ch = char.ToUpper(ch);
        return (ch == 'A' || ch == 'E' ||
                ch == 'I' || ch == 'O' ||
                ch == 'U') == false &&
                ch >= 65 && ch <= 90;
    }
    static int totalConsonants(String str, int n)
    {
        if (n == 1)
        {
            if (isConsonant(str[0]))
                return 1;
            else
                return 0;
        }
        if (isConsonant(str[n - 1]))
            return totalConsonants(str, n - 1) + 1;
        else
            return totalConsonants(str, n - 1);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a String: ");
        String str;
        str = Console.ReadLine();
        Console.WriteLine("Number of Consonants: " + totalConsonants(str, str.Length));

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

