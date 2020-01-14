using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise8
    {
        public static void exercise()
        {
            Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());


            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());


            double testatlo = Math.Sqrt((length * length) + (width*width) + (height * height));
            Console.WriteLine("Testatlo = " + testatlo);


            double lapatlo = Math.Sqrt((length * length) + (width* width));
            Console.WriteLine("Lapatlo = " + lapatlo);

            double area = ((length * width) + (length * height) + (width * height)) * 2;
            Console.WriteLine("Area = " + area);

            double volume = length * width * height;
            Console.WriteLine("Volume = " + volume);



        }
    }
}
