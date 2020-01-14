using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise14
    {
        public static void exercise()
        {
            Console.WriteLine("Income for this year in $: ");
            double income = double.Parse(Console.ReadLine());

            Console.WriteLine("Expense for this year in $: ");
            double expense = double.Parse(Console.ReadLine());

            if (income > expense)
            {
                Console.WriteLine("This was a profitable year!");
            }
            else if (expense > income)
            {
                Console.WriteLine("This was an unprofitable year!");
            }
            else
            {
                Console.WriteLine("0$ sum year.");
            }



        }
    }
}
