using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing overloaded methods...");
            Console.ReadKey(true);
            Console.WriteLine("Add two int's, 5 and 3: " + Add(5 , 3));
            Console.ReadKey(true);
            Console.WriteLine("Add two decimals, 5.5 and 30.125: " + Add(5.5m, 30.125m));
            Console.ReadKey(true);
            Console.WriteLine("Add two dollar amounts with/without word 'dollar(s)':");
            Console.WriteLine(Add(5, 3, true));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(0, 6, false));
            Console.ReadKey(true);
            Console.WriteLine("Goodbye.");
            Console.ReadKey(true);
            return;
        }

        static int Add(int a, int b) => a + b;
        static decimal Add(decimal a, decimal b) => a + b;
        static string Add(int a, int b, bool isDollars)
        {
            if (isDollars)
            {
                if (a + b == 1) return "One dollar";
                else return $"{a+b} dollars";
            }
            else return $"{a + b}";
        }
    }
}
