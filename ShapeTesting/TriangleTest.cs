namespace ShapeTesting
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestCalculateAreaForRightTriangle()
        {
            IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            double expectedArea = 6; 
            double calculatedArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, calculatedArea, 0.001);
        }

        [TestMethod]
        public void TestCalculateAreaForNonRightTriangle()
        {
            IShape triangle = ShapeFactory.CreateTriangle(6, 8, 10);
            double expectedArea = 24;
            double calculatedArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, calculatedArea, 0.001);
        }
    }
}