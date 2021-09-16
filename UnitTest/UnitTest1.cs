using CalcArea.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCorrectCircle()
        {
            var factory = new Factory();
            var myCircle = factory.CreateFigure(FigureType.Circle, 2);
            Assert.AreEqual(myCircle.CalculateArea(), 12,566370614359172);
        }

        [TestMethod]
        public void TestUnCorrectCircle()
        {
            var factory = new Factory();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => factory.CreateFigure(FigureType.Circle, -1));
        }

        [TestMethod]
        public void TestZeroCircle()
        {
            var factory = new Factory();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => factory.CreateFigure(FigureType.Circle, 0));
        }

        [TestMethod]
        public void TestCorrectTriangle()
        {
            var factory = new Factory();
            var myTriangle = factory.CreateFigure(FigureType.Triangle, 3, 4, 5);
            Assert.AreEqual(myTriangle.CalculateArea(), 6);
        }

        [TestMethod]
        public void TestUnCorrectTriangle()
        {
            var factory = new Factory();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => factory.CreateFigure(FigureType.Triangle, 10, 2, 1));
        }

        [TestMethod]
        public void TestZeroTriangle()
        {
            var factory = new Factory();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => factory.CreateFigure(FigureType.Triangle, 0, 0, 0));
        }
    }
}
