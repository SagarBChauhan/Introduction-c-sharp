using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit_one
{
    class odd_even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value 1:");
            int v1 = Convert.ToInt32(Console.ReadLine());

            if (v1 % 2 == 0 )
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadLine();

        }
    }
}
