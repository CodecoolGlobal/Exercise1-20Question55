using System;
using System.Collections.Generic;
using System.Text;


namespace Exercise1_20
{
    class Exercise1
    {
        public static void exercise()
        {
            Console.WriteLine("Please type in the radius: ");
            int r = Int32.Parse(Console.ReadLine());

            double circumfrence = (Math.PI) * r * 2;

            double area = (Math.PI) * r * r;

            double surfaceArea = 4 * (Math.PI) * r * r;

            double volume = 4 / 3 * (Math.PI) * r * r * r;

            Console.WriteLine("Circumfrence is: " + circumfrence);
            Console.WriteLine("Area is: " + area);
            Console.WriteLine("Surface Area is: " + surfaceArea);
            Console.WriteLine("Volume is: " + volume);



        }




    }
}
