using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise11
    {
        public static int sum;
        public static void exercise()
        {

            Console.WriteLine("Type an integer: ");
            string Snum = Console.ReadLine();

            foreach (var integer in Snum)
            {
                sum += integer;
            }

            if (sum % 9 == 0)
            {
                Console.WriteLine("Given integer can be divided by 9.");

            }
            else
            {
                Console.WriteLine("Given integer CAN'T be divided by 9.");
            }



        }
    }
}
