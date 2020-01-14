using System;
using System.Collections.Generic;

namespace Exercise1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Exercise1.exercise();

            Exercise2.exercise();

            Exercise3.exercise();

            Exercise4.exercise();

            Exercise5.exercise();

            Exercise6.exercise();

            Exercise7.exercise();

            Exercise8.exercise();

            Exercise10.exercise();

            Exercise11.exercise();

            Exercise12.exercise();

            Exercise13.exercise();

            Exercise14.exercise();

            Exercise15.exercise();
            
            Exercise16.exercise();

            Exercise17.exercise();

            Exercise18.exercise();

            Exercise19.exercise(); 

            Exercise20.exercise(); 

            //Below is Question 55 
            Question55();





        }
        public static void Question55()
        {
            List<Szoba> Szobak = new List<Szoba>();

            Console.WriteLine("How many rooms? ");
            int NumberOfRooms = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfRooms; i++)
            {
                Console.WriteLine("Length: ");
                int length = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Height: ");
                int height = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Width: ");
                int width = Int32.Parse(Console.ReadLine());

                Szoba room1 = new Szoba(length, width, height);

                Szobak.Add(room1);

            }

            foreach (Szoba szoba in Szobak)
            {
                Console.WriteLine("Amount of paint you need is: " + (szoba.GetPaint()));
                Console.WriteLine("Amount of rock you need is: " + (szoba.GetStone()));
            }


        }

    }
}
