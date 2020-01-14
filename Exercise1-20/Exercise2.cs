using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1_20
{
    class Exercise2
    {
        private static int[] orderedNums;


        public static void exercise()
        {

        Console.WriteLine("Number1: ");
            int num1 = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Number2: ");
            int num2 = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Number3: ");
            int num3 = Int32.Parse(Console.ReadLine());

        int[] numbers = new int[] { num1, num2, num3 };

        orderedNums = numbers.OrderByDescending(i => i).ToArray();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

    }
}
}

