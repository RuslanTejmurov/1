using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using MyMath;

namespace MyMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(Algebra.Sqr(-4, 28, -49));
            Console.WriteLine(Algebra.LinearSqr(6,-24));
            Console.WriteLine(Algebra.SumRow(arr));
            Console.WriteLine(Algebra.MaxRow(arr));
            Console.WriteLine(Algebra.AverageRow(arr));

            Console.WriteLine();
            
            Console.WriteLine(Geometry.STriangle(10,5));
            Console.WriteLine(Geometry.SRightTriangle(4,6));
            Console.WriteLine(Geometry.SRectangle(7,10));
            Console.WriteLine(Geometry.SRound(5));
            Console.WriteLine(Geometry.Trapezoid(10,8,5));

            Console.WriteLine();

            Console.WriteLine(Trigonometry.Sin(6,12));
            Console.WriteLine(Trigonometry.Cos(4,12));
            Console.WriteLine(Trigonometry.Tg(6,4));
            Console.WriteLine(Trigonometry.Ctg(8,10));
            Console.WriteLine(Trigonometry.ArcSin(1));

            Console.ReadKey();
        }
    }
}
