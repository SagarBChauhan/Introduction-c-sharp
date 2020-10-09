using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit_one
{
    class swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Number b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("value of a :" + a);
            Console.WriteLine("Value of b :" + b);
            Console.ReadLine();

        }
    }
}
