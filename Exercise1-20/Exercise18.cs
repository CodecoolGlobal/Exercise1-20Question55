using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise18
    {
        public static void exercise()
        {
            Console.WriteLine("Please type the average monthly temperatures!");

            Console.WriteLine("January: ");
            double jan = double.Parse(Console.ReadLine());
            Console.WriteLine("February: ");
            double feb = double.Parse(Console.ReadLine());
            Console.WriteLine("Marach: ");
            double mar = double.Parse(Console.ReadLine());
            Console.WriteLine("April: ");
            double apr = double.Parse(Console.ReadLine());
            Console.WriteLine("May: ");
            double may = double.Parse(Console.ReadLine());
            Console.WriteLine("June: ");
            double jun = double.Parse(Console.ReadLine());
            Console.WriteLine("July: ");
            double jul = double.Parse(Console.ReadLine());
            Console.WriteLine("August: ");
            double aug = double.Parse(Console.ReadLine());
            Console.WriteLine("September: ");
            double sept = double.Parse(Console.ReadLine());
            Console.WriteLine("October: ");
            double oct = double.Parse(Console.ReadLine());
            Console.WriteLine("November: ");
            double nov = double.Parse(Console.ReadLine());
            Console.WriteLine("December: ");
            double dec = double.Parse(Console.ReadLine());


            double avgYearlyTemp = (jan+feb+mar+apr+may+jun+jul+aug+sept+oct+nov+dec)/ 12;
            Console.WriteLine("The average yearly temperature is: " + avgYearlyTemp);
        }
    }
}
