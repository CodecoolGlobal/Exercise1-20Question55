using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Exercise9
    {
        
        public static void exercise()
        {
            Console.WriteLine("Length: ");
            int l = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            int w = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Height: ");
            int h = Int32.Parse(Console.ReadLine());

            int sum = (l + w + h) * 4;
            Console.WriteLine("Sum of all sides is: " + sum);

           

        } 

    }
}
