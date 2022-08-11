using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            double radius1 = (double)radius;
            return Math.PI * (radius1 * radius1);
        }
        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return ((double)(length * width));
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return ((double) (ground * h) / 2);
        }
    }
}
