using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise13
    {
        public static void exercise()
        {
            Console.WriteLine("Name of the month: ");
            string month = Console.ReadLine();

            if ((month == "January") || (month == "December") || (month == "February"))
                {
                Console.WriteLine( "Given month is in Winter");
            }
            else if ((month == "March") || (month == "April") || (month == "May"))
            {
                Console.WriteLine("Given month is in Spring");
            } else if ((month == "June") || (month == "July") || (month == "August"))
            {
                Console.WriteLine("Given month is in Summer");
            } else if ((month == "September") || (month == "October") || (month == "November"))
            {
                Console.WriteLine("Given month is in Autumn");
            }
            else
            {
                Console.WriteLine("Incorrect input! Please type a month with the first letter being a capital letter!");
            }

            



        }
    }
}
