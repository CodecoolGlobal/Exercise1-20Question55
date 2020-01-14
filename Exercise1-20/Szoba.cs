using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_20
{
    class Szoba
    {
        public int Length { get; set; }
       
        public int Height { get; set; }

        public int Width { get; set; }

        /*
            Console.WriteLine("How many rooms: (Type an integer)");
            int rooms = Int32.Parse(Console.ReadLine());
            */
        public Szoba(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int GetPaint()
        {
            int SurfaceArea = (Length * Width) + (Length * Height * 2) + (Height * Width * 2);

            return SurfaceArea;
        }

        public int GetStone()
        {
            int ko = Length * Width;

            return ko;
        }



    }
}
