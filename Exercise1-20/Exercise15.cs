using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise15
    {
        public static void exercise()
        {
            Console.WriteLine("Do you speak Hungarian? (yes or no)");
            string userInput1 = Console.ReadLine();

            if (userInput1 == "yes")
            {
                Console.WriteLine("Szia!");
            }
            else if (userInput1 == "no")
            {
                Console.WriteLine("Do you speak English? (yes or no)");
                string userInput2 = Console.ReadLine();

                if (userInput2 == "yes")
                {
                    Console.WriteLine("Hi!");
                } else if (userInput2 == "no")
                {
                    Console.WriteLine("Do you speak Italian? (yes or no)");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "yes")
                    {
                        Console.WriteLine("Chao!");
                    } else if (userInput3 == "no")
                    {
                        Console.WriteLine("♥");
                    }

                }


            }
            else
            {
                Console.WriteLine("Invalid input! Type 'yes' or 'no'!");
            }


        }
    }
}
