using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(ref p1, ref p2);
            p1.PrintPoint();
            p2.PrintPoint();
        }
        public static void SwapPoints(ref Point p1, ref Point p2)
        {
            Point p3 = p2;
            p2 = p1;
            p1 = p3;
        }
    }
}
