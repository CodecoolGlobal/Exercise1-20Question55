using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise6
    {

        public static void exercise()
        {
            Console.WriteLine("Type true or false!");
            bool userInput = bool.Parse(Console.ReadLine());

            if (userInput == true)
            {
                Console.WriteLine("IGAZ!");
            }
            else if ((!userInput == true) || (!userInput == false))
            {
                Console.WriteLine("Invalid input! Please type TRUE or FALSE!");
            }


        }
    }
}
