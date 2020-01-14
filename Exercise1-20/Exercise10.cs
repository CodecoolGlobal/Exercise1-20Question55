using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise10
    {
        public static void exercise()
        {
            Console.WriteLine("Give amount in deciliter: ");
            double dl = double.Parse(Console.ReadLine());

            double l = dl / 10;
            double hl = l / 100;

            Console.WriteLine("Given amount in liter: " + l);
            Console.WriteLine("Given amount in hectoliter: " + hl);
            Console.WriteLine("Given amount in deciliter: " + dl);


        }
    }
}
