using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise16
    {
        public string pswdchecker;

        public static void exercise()
        {
            Console.WriteLine("Type your password (only letters are accepted): ");
            string pswd = Console.ReadLine();


            for (int i = 0; i<1000000000; i++)
            {
                Console.WriteLine("Type your password again: ");
                string pswdchecker = Console.ReadLine();

                if (pswd == pswdchecker)
                {
                    Console.WriteLine("Successful!");
                    break;
                }
                else if (pswd != pswdchecker)
                {
                    Console.WriteLine("Incorrect! Try again!");
                }
            }
            

        }
    }
}
