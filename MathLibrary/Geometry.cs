using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Geometry
    {
        public static double STriangle(double a, double h)
        {
            double S = 0.5 * a * h;
            return S;
        }
        public static double SRightTriangle(double a, double b)
        {
            return 0.5 * (a * b);
        }

        public static double SRectangle(double a, double b)
        {
            return a * b;
        }

        public static double SRound(double r)
        {
            double p = 3.14;
            return p * Math.Pow(r, 2);
        }
        public static double Trapezoid(double a, double b, double h)
        {
            double S = (a + b) * h / 2;
            return S;
        } 
    }
}
