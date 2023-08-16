using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTesting
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestCalculateAreaForCircle()
        {
            IShape triangle = ShapeFactory.CreateCircle(5);
            double expectedArea = 78.5;
            double calculatedArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, calculatedArea, 0.05);
        }

    }
}
