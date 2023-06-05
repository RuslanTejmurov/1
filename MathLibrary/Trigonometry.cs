using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Trigonometry
    {
        public static double Sin(double opposite, double hypo)
        {
            return opposite / hypo;
        }
        public static double Cos(double adjacent, double hypo)
        {
            return adjacent / hypo;
        }
        public static double Tg(double opposite, double adjacent)
        {
            return opposite / adjacent;
        }
        public static double Ctg(double opposite, double adjacent)
        {
            return adjacent / opposite;
        }
        public static double ArcSin(double a)
        {
            return Math.Asin(a);
        }
    } 
}
