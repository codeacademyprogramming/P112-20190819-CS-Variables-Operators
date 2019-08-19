using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;

            a /= 0;
            Console.WriteLine(a);
            // a = a + 20;
            a += 20;
            Console.WriteLine(a);

            // a = a - 5;
            a -= 5;
            Console.WriteLine(a);

            // a = a * 3;
            a *= 3;
            Console.WriteLine(a);

            // a = a / 10;
            a /= 10;
            Console.WriteLine(a);

            // a = a % 15;
            a %= 10;
            Console.WriteLine(a);



            Console.ReadLine();
        }
    }
}
