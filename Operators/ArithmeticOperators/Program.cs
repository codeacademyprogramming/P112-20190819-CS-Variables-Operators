using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int a, b;
            a = 100;
            b = 10;
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            result = a + b;
            Console.WriteLine("Toplamanin neticesi " + result);
            result = a - b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);
            result = a % b;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
