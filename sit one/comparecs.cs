using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit_one
{
    class comparecs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Value:");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Value:");
            int v2 = Convert.ToInt32(Console.ReadLine());

            if (v1 == v2)
            {
                Console.WriteLine("Compare Number");
            }
            else
            {
                Console.WriteLine("Not Compare Number");
            }
            Console.ReadLine();
        }
    }
}
