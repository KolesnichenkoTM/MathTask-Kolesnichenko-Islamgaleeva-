using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTask_Kolesnichenko_Islamgaleeva_;


namespace MathTaskTest_Kolesnichenko_Islamgaleeva_
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            int h = 5;
            int expected = 251;
            Geometry g = new Geometry();
            double actual = g.RectangleArea(a, h);

            Assert.AreEqual(expected, actual);

        }
    }
}
