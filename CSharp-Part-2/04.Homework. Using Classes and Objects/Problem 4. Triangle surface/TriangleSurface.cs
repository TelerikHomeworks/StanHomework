using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Triangle_surface
{
    class TriangleSurfaceClass
    {

        static double TriangleSurface(double side, double atitude)
        {
            return (side * atitude) / 2;
        }
        static double TriangleSurface(double a, double b, double c)
        {
            double semiPerimeter = (a + b + c)/2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }
        static double TriangleSurfaceByAngleAndTwoSides(double a, double b, double angle)
        {
            return a * b * Math.Sin(angle) / 2;
        }

        static void Main(string[] args)
        {
            double a = 8;
            double b = 9;
            double c = 11;
            
            double aSecond = 5;
            double bSecond = 7;
            double angle = 45;

            double aThird = 14;
            double atitudeThird = 10;
            Console.WriteLine("{0:0.00}", TriangleSurface(a, b, c));
            Console.WriteLine("{0:0.00}", TriangleSurfaceByAngleAndTwoSides(aSecond, bSecond, angle));
            Console.WriteLine("{0:0.00}", TriangleSurface(aThird,atitudeThird));
        }
    }
}
