using System;

namespace ConsoleDemo
{

    class Program
    {
        static void Main(string[] args)
        {
           // int num1 = 5;
            int num2 = 10;
            /*Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2); */

            Console.ReadLine();
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }
    }
}
