using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ingus.Triangle.Checker.Tests
{
    [TestClass]
    public class TypeCheckerTests
    {
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(10, 10, 10)]
        [DataRow(5.5, 5.5, 5.5)]
        [DataRow(0.7, 0.7, 0.7)]
        public void Equilateral(double a, double b, double c)
        {
            var type = TypeChecker.GetTriangleType(a, b, c);
            Assert.IsTrue(type == TriangleType.Equilateral);
        }

        [DataTestMethod]
        [DataRow(1, 1, 0.5)]
        [DataRow(10, 10, 1)]
        [DataRow(5.5, 5.5, 8.2)]
        [DataRow(0.7, 0.7, 1.39)]
        public void Isosceles(double a, double b, double c)
        {
            var type = TypeChecker.GetTriangleType(a, b, c);
            Assert.IsTrue(type == TriangleType.Isoseles);
        }

        [DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(10, 15, 20)]
        [DataRow(5.5, 5.7, 8.4)]
        [DataRow(0.7, 0.5, 0.4)]
        public void Scalene(double a, double b, double c)
        {
            var type = TypeChecker.GetTriangleType(a, b, c);
            Assert.IsTrue(type == TriangleType.Scalene);
        }

        [DataTestMethod]
        [DataRow(0, 4, 5)]
        [DataRow(3, 0, 5)]
        [DataRow(3, 4, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 2, 3)]
        [DataRow(5, 2, 7)]
        [DataRow(12.8, 6.4, 6.4)]
        [DataRow(10, 2, 4)]
        public void None(double a, double b, double c)
        {
            var type = TypeChecker.GetTriangleType(a, b, c);
            Assert.IsTrue(type == TriangleType.None);
        }
    }
}
