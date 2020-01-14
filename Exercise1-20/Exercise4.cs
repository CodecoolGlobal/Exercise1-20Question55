using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise4
    {
        public static void exercise()
        {
            Console.WriteLine("Type a positive or negative integer: ");
            int num = Int32.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Given number is NEGATIVE!");
            }
            else
            {
                Console.WriteLine("Given number is POSITIVE!");
            }

        }



    }
}
