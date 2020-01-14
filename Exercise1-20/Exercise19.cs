using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise19
    {
        public static void exercise()
        {
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("(1) Without cup");
            Console.WriteLine("(2) Double");
            Console.WriteLine("(3) Foamy");
            Console.WriteLine("(0) Regular");
            Console.WriteLine("(Type the number)");
            int userInput = Int32.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                Console.WriteLine("Please pay 70ft!");
            }
            else if (userInput == 1)
            {
                Console.WriteLine("Please pay 60Ft!");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Please pay 90Ft!");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Please pay 120Ft!");
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again!");
            }


        }
    }
}
