using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_5;

namespace TestMyTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perimeter3x0_6x0_0x5_return16_64()
        {
            //arrange
            Point p1 = new Point(3, 0);
            Point p2 = new Point(6, 0);
            Point p3 = new Point(0, 5);
            double expected = 16.64;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Perimeter1x2_7x2_3x3_return12_36()
        {
            //arrange
            Point p1 = new Point(1, 2);
            Point p2 = new Point(7, 2);
            Point p3 = new Point(3, 3);
            double expected = 12.36;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area3x0_6x0_0x5_return7_49()
        {
            //arrange
            Point p1 = new Point(3, 0);
            Point p2 = new Point(6, 0);
            Point p3 = new Point(0, 5);
            double expected = 7.49;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Area();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area1x2_7x2_3x3_return3()
        {
            //arrange
            Point p1 = new Point(1, 2);
            Point p2 = new Point(7, 2);
            Point p3 = new Point(3, 3);
            double expected = 3;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Area();

            //assert
            Assert.AreEqual(expected, result);
        }


    }
}
