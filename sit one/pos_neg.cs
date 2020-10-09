using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit_one
{
    class pos_neg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int v1 = Convert.ToInt32(Console.ReadLine());

            if (v1 > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (v1 < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (v1 == 0)
            {
                Console.WriteLine("zero Number");
            }
            else
            {
                Console.WriteLine("Envalid Number");
            }
            Console.ReadLine();
        }
    }
}
