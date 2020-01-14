using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise17
    {
        public static void exercise()
        {
            Console.WriteLine("Type the month's number (january = 1, sepetmber = 9 etc.): ");
            int month = Int32.Parse(Console.ReadLine());

            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine("Given month is in Winter!");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Given month is in Spring!");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Given month is in Summer!");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Given month is in Autumn!");
            }
            else
            {
                Console.WriteLine("Invalid input! Please type a month's number!");
            }





        }
    }
}
