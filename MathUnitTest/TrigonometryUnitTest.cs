using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUnitTest
{
    [TestClass]
    public class TrigonometryUnitTest
    {
        [TestMethod]
        public void Sina2b8s025()
        {
            double a = 2, b = 8, s = 0.25, res = Trigonometry.Sin(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Sina4b8s05()
        {
            double a = 4, b = 8, s = 0.5, res = Trigonometry.Sin(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Sina2b10s025()
        {
            double a = 2, b = 10, s = 0.2, res = Trigonometry.Sin(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void Cosa5b10s05()
        {
            double a = 5, b = 10, s = 0.5, res = Trigonometry.Cos(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Cosa4b10s04()
        {
            double a = 4, b = 10, s = 0.4, res = Trigonometry.Cos(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Cosa6b10s06()
        {
            double a = 6, b = 10, s = 0.6, res = Trigonometry.Cos(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void Tga5b5s1()
        {
            double a = 5, b = 5, s = 1,
                res = Trigonometry.Tg(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Tga5b10s05()
        {
            double a = 5, b = 10, s = 0.5,
                res = Trigonometry.Tg(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Tga4b8s05()
        {
            double a = 4, b = 8, s = 0.5,
                res = Trigonometry.Tg(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void Ctga4b8s2()
        {
            double a = 4, b = 8, s = 2, res = Trigonometry.Ctg(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Ctga5b15s3()
        {
            double a = 5, b = 15, s = 3, res = Trigonometry.Ctg(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Ctga1b2s2()
        {
            double a = 1, b = 2, s = 2, res = Trigonometry.Ctg(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void ArcSinam05()
        {
            double a = -0.5, s = -0.5, res = Math.Round(Trigonometry.ArcSin(a),1);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void ArcSina05()
        {
            double a = 0.5, s = 0.5, res = Math.Round(Trigonometry.ArcSin(a), 1);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void ArcSina01()
        {
            double a = 0.1, s = 0.1, res = Math.Round(Trigonometry.ArcSin(a),1);
            Assert.AreEqual(s, res);
        }
    }
}
