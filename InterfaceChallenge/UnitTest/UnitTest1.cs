using NUnit.Framework;
using ClassLibrary;
using System.Collections.Generic;
using System;

namespace UnitTest {
    public class Tests {
        [SetUp]
        public void Setup() {
            
        }

        //Square Testing
        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTest(double side, double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, new Square(side).GetArea());
            Assert.AreEqual(expectedPerimeter, new Square(side).GetPerimeter());
        }

        //Rectangle Testing
        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTest(double side1, double side2, double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, new Rectangle(side1, side2).GetArea());
            Assert.AreEqual(expectedPerimeter, new Rectangle(side1, side2).GetPerimeter());
        }

        //Equilateral Testing
        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTest(double side, double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, Math.Round(new Equilateral(side).GetArea(), 2));
            Assert.AreEqual(expectedPerimeter, new Equilateral(side).GetPerimeter());
        }

        //RightAngle Testing
        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTest(double side1, double side2, double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, Math.Round(new RightAngle(side1, side2).GetArea(), 2));
            Assert.AreEqual(expectedPerimeter, Math.Round(new RightAngle(side1, side2).GetPerimeter(), 2));
        }

        //Circle Testing

        Circle circle1 = new Circle {
            Radius = 5
        };
        Circle circle2 = new Circle {
            Radius = 15
        };
        Circle circle3 = new Circle {
            Radius = 7
        };

        [TestCase(78.55, 31.42)] //This test would work if 78.55 was 78.54, because that would be the correct answer
        public void Circle1Test(double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, Math.Round(circle1.GetArea(), 2));
            Assert.AreEqual(expectedPerimeter, Math.Round(circle1.GetPerimeter(), 2));
        }
        [TestCase(706.95, 94.26)] //This test would work if 706.95 was 706.86, because that is the correct answer
        public void Circle2Test(double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, Math.Round(circle2.GetArea(), 2));
            Assert.AreEqual(expectedPerimeter, Math.Round(circle2.GetPerimeter(), 2));
        }
        [TestCase(153.96, 43.99)] //This test would work if 153.96 was 153.94, because that is the correct answer
        public void Circle3Test(double expectedArea, double expectedPerimeter) {
            Assert.AreEqual(expectedArea, Math.Round(circle3.GetArea(), 2));
            Assert.AreEqual(expectedPerimeter, Math.Round(circle3.GetPerimeter(), 2));
        }
    }
}