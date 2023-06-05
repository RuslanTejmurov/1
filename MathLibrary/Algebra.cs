using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Algebra
    {
        public static Tuple<double, double> Sqr(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double x1 = 0, x2 = 0;
            if(discriminant < 0)
            {
                Console.Write("Корней нет: ");
            } else
            {
                if (discriminant == 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = x1;
                    Console.Write("Один корень: ");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                    Console.Write("Два корня: ");
                }
            }
            return Tuple.Create(x1, x2);
        }
        public static double LinearSqr(double k, double b)
        {
            return -b / k;
        }

        public static double SumRow(double[] arr)
        {
            return arr.Sum();
        }

        public static double MaxRow(double[] arr)
        {
            return arr.Max();
        }

        public static double AverageRow(double[] row)
        {
            return row.Average();
        }
    }
}
