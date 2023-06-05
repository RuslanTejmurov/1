using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUnitTest
{   [TestClass]
    public class AlgebraTest
    {
        [TestMethod]
        public void Sqrm428m49e59()
        {
            double a = -4,
                   b = 28,
                   c = -49;
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;

            var res = Algebra.Sqr(-4, 28, -49);

            Assert.AreEqual(Tuple.Create(x1, x2), res);
        }  
        [TestMethod]
        public void Sqr1a8b15cx1m5x2m3()
        {
            double a = 1,
                   b = 8,
                   c = 15;
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;

            var res = Algebra.Sqr(1,8,15);

            Assert.AreEqual(Tuple.Create(x1, x2), res);
        }
        [TestMethod]
        public void Sqr5a3bm26x1x20()
        {
            double a = 5,
                   b = 3,
                   c = -26;
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;

            var res = Algebra.Sqr(5, 3, -26);

            Assert.AreEqual(Tuple.Create(x1, x2), res);
        }

        [TestMethod]
        public void LinearSqrbm24k6r()
        {
            double b = 24,
                   k = 6,
                   res = -4;
            Assert.AreEqual(res, Algebra.LinearSqr(k, b));
        }
        [TestMethod]
        public void LinearSqr1bm11kx10()
        {
            double b = -10,
                   k = 1,
                   res = 10;
            Assert.AreEqual(res, Algebra.LinearSqr(k, b));
        }

        [TestMethod]
        public void SumRow123()
        {
            double[] arr = { 1, 2, 3 };
            double res = 6;
            Assert.AreEqual(res, Algebra.SumRow(arr));
        } 
        [TestMethod]
        public void SumRow12410()
        {
            double[] arr = { 1, 2, 4, 10 };
            double res = 17;
            Assert.AreEqual(res, Algebra.SumRow(arr));
        }
        [TestMethod]
        public void SumRowm5m555r0() {
            double[] arr = { -5, -5, 5, 5 };
            double res = 0;
            Assert.AreEqual(res, Algebra.SumRow(arr));
        }

        [TestMethod]
        public void MaxRow123r3()
        {
            double[] arr = { 1, 2, 3 };
            double res = 3;
            Assert.AreEqual(res, Algebra.MaxRow(arr));
        }
        [TestMethod]
        public void MaxRow6m2m605rm6()
        {
            double[] arr = { 6, -2, -6, 0, 5 };
            double res = 6;
            Assert.AreEqual(res, Algebra.MaxRow(arr));
        }
        [TestMethod]
        public void MaxRow000m2r0()
        {
            double[] arr = { 0, 0, 0, -2 };
            double res = 0;
            Assert.AreEqual(res, Algebra.MaxRow(arr));
        }

        public void AverageRow123r3()
        {
            double[] arr = { 1, 2, 3 };
            double res = 2;
            Assert.AreEqual(res, Algebra.AverageRow(arr));
        }
        [TestMethod]
        public void AverageRow6m2m605rm6()
        {
            double[] arr = { 6, -2, -6, 0, 5 };
            double res = 0.6;
            Assert.AreEqual(res, Algebra.AverageRow(arr));
        }
        [TestMethod]
        public void AverageRow000m2r0()
        {
            double[] arr = { 0, 0, 0, -2 };
            double res =- 0.5;
            Assert.AreEqual(res, Algebra.AverageRow(arr));
        }
    }
}
