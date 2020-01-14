using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1_20
{
    class Exercise7
    {
        public static void exercise()
        {
            Console.WriteLine("Type pair of numbers: "); // meghivja
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int midpoint = (numbers[0] + numbers[1]) / 2;

            Console.WriteLine(midpoint);




        }
    }
}
