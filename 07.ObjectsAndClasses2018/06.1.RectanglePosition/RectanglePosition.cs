using System;
using System.Linq;

namespace _06._1.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle(),
            r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2)? "Inside" : "Not inside");
        }
        public static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine().Split(" ").Select(double.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Height = size.Skip(3).First(),
            };
            return rectangle;
        }

    }
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double  Height { get; set; }

        public double Right { get { return Left + Width; } }
        public double Bottom { get { return Top + Height; } }

        public bool IsInside(Rectangle other)
        {
            var isInLeft = Left >= other.Left;
            var isInRight = Right <= other.Right;
            var isInsideHorizontal = isInLeft && isInRight;

            var isInTop = Top >= other.Top;
            var isInBottom = Bottom <= other.Bottom;
            var isInsideVertikal = isInTop && isInBottom;

            return isInsideHorizontal && isInsideVertikal;
        }
    }
}
