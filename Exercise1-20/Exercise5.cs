using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise5
    {

        public static void exercise()
        {
            Console.WriteLine("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            Console.WriteLine("Sum of A and B: " + sum);

            double diff = a - b;
            Console.WriteLine("Difference of A and B: " + diff);

            double mult = a * b;
            Console.WriteLine("Muliplication of A and B: " + mult);

            double div = a / b;
            Console.WriteLine("Division of A and B: " + div);







        }
    }
}
