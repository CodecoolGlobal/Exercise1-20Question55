using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise12
    {
        public static void exercise()
        {
            Console.WriteLine("Type a not negative, whole number: ");
            double num = double.Parse(Console.ReadLine());

            double digits = Math.Ceiling(Math.Log10(num));

            Console.WriteLine("Given number is: " + digits + " digit long.");


        }
    }
}
