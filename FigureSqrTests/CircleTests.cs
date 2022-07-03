using NUnit.Framework;
using System;
using FigureSqr;

namespace FigureSqrTests
{
    public class CircleTests
    {
        [Test]
        public void CalcSquare_Input4()
        {
            var circle = new Circle(4);

            var result = circle.CalcSquare();

            Assert.IsTrue(Math.Abs(result - 50.2655) < 0.001);
        }

        [Test]
        public void Circle_Input0()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
        [Test]
        public void Circle_InputNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-4));
        }

        [Test]
        public void CalcPerimeter_Input4()
        {
            var circle = new Circle(4);

            var result = circle.CalcPerimeter();

            Assert.IsTrue(Math.Abs(result - 25.1327) < 0.001);
        }

    }
}