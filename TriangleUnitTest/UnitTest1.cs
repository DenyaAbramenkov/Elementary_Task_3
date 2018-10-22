using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elementary_Task_3;
using System.Collections.Generic;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        [DataRow("-3", "2", "0")]
        [DataRow("3", "4", "20")]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleBuild_ExceptionThrow(string sideA, string sideB, string sideC)
        {
            //Arrange

            //Act
            Triangle triangle = Triangle.TriangleInitializer("", sideA, sideB, sideC);

            //Assert
        }

        [TestMethod]
        public void TestListOfTrianglesSort_Correct()
        {
            //Arrange

            //Act
            Triangle triangleFirst = Triangle.TriangleInitializer("firstTriangle","4", "6", "7");
            Triangle triangleSecond = Triangle.TriangleInitializer("secondTriangle","7", "11", "9");
            Triangle triangleThird = Triangle.TriangleInitializer("thirdTriangle", "3", "4", "5");
            List<Triangle> actual = new List<Triangle> { triangleFirst, triangleSecond, triangleThird };
            List<Triangle> expected = new List<Triangle> { triangleSecond, triangleFirst, triangleThird };
            actual.Sort();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
