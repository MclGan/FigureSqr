using FigureSqr;
using System;
using NUnit.Framework;

namespace FigureSqrTests
{
    public class TriangleTests
    {
        [Test]
        public void CalcSquare_Input456()
        {
            var triangle = new Triangle(4, 5, 6);

            var result = triangle.CalcSquare();

            Assert.IsTrue(Math.Abs(result - 9.9216) < 0.001);
        }

        [Test]
        public void CalcPerimeter_Input456()
        {
            var triangle = new Triangle(4, 5, 6);

            var result = triangle.CalcPerimeter();

            Assert.IsTrue(Math.Abs(result - 15) < 0.001);
        }

        [Test]
        public void Triangle_InCorrectInput056()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0,5,6));
        }

        [Test]
        public void Triangle_InCorrectInput7756()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(77, 5, 6));
        }

        [Test]
        public void Triangle_InCorrectInputNegative456()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-4, 5, 6));
        }

        [Test]
        public void IsRightTriangle_True()
        {
            var triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRightTriangle();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsRightTriangle_False()
        {
            var triangle = new Triangle(5, 5, 7);

            var result = triangle.IsRightTriangle();

            Assert.IsFalse(result);
        }
    }
}