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
    public class GeometyUnitTest
    {
        [TestMethod]
        public void STrianglea6h3s9()
        {
            double s = 9,
                   a = 6,
                   h = 3;
            double res = Geometry.STriangle(a, h);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void STrianglea10h3s15()
        {
            double s = 15,
                   a = 10,
                   h = 3;
            double res = Geometry.STriangle(a, h);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void STrianglea10h5s25()
        {
            double s = 25,
                   a = 10,
                   h = 5;
            double res = Geometry.STriangle(a, h);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SRightTrianglgea2b2s2()
        {
            double s = 2,
                a = 2,
                b = 2,
                res = Geometry.SRightTriangle(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRightTrianglgea4b2s4()
        {
            double s = 4,
                a = 4,
                b = 2,
                res = Geometry.SRightTriangle(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRightTrianglgea8b2s8()
        {
            double s = 8,
                a = 8,
                b = 2,
                res = Geometry.SRightTriangle(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SRectanglea2b4s8()
        {
            double a = 2, b = 4, s = 8,
                res = Geometry.SRectangle(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRectanglea4b4s16()
        {
            double a = 4, b = 4, s = 16,
                res = Geometry.SRectangle(a, b);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRectanglea5b5s25()
        {
            double a = 5, b = 5, s = 25,
                res = Geometry.SRectangle(a, b);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SRoundr2s1256()
        {
            double r = 2, s = 12.56,
                res = Geometry.SRound(r);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRoundr4s5024()
        {
            double r = 4, s = 50.24,
                res = Geometry.SRound(r);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void SRoundr5s785()
        {
            double r = 5, s = 78.5,
                res = Geometry.SRound(r);
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void Trapezoida4b4h2s12()
        {
            double a = 4, b = 4, s = 8,h = 2, res = Geometry.Trapezoid(a, b, h);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Trapezoida4b6h2s10()
        {
            double a = 4, b = 6, s = 10, h = 2, res = Geometry.Trapezoid(a, b, h);
            Assert.AreEqual(s, res);
        }
        [TestMethod]
        public void Trapezoida8b5h4s26()
        {
            double a = 8, b = 5, s = 26, h = 4, res = Geometry.Trapezoid(a, b, h);
            Assert.AreEqual(s, res);
        }
    }
}
