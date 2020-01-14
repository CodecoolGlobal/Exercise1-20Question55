using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise3
    {
        public static void exercise()
        {
            Console.WriteLine("A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("C: ");
            int c = Int32.Parse(Console.ReadLine());

            if ((a+b > c) && (a+c>b) && (c+b> a))
            {

                Console.WriteLine("The triangle is compileable!");
            }
            else
            {
                Console.WriteLine("Triangle is NOT compileable!");
            }






        }



    }
}
