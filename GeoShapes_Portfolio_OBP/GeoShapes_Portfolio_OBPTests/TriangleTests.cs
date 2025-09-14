using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoShapes_Portfolio_OBP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_Portfolio_OBP.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()] //test mit default werte
        public void Tr_PerimeterTest()
        {
            // Arrange
            Triangle t = new Triangle(); // default werte sind: 3,4,5

            // Act
            int result = t.Tr_Perimeter();

            // Assert
            Assert.AreEqual(12, result); // 3+4+5 = 12
        }

        [TestMethod()] //test mit custom werte
        public void Tr_PerimeterTest1()
        {

            // Arrange
            Triangle t = new Triangle(10,24,12); // custom werte eingegeben

            // Act
            int result = t.Tr_Perimeter();

            // Assert
            Assert.AreEqual(46, result); // 10 + 12 + 24 = 46
        }
    }
}