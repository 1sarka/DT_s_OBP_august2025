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
    public class RectangleTests
    {
        [TestMethod()] // rechtecke flache kalkulation test
        public void Rect_AreaTest()
        {
            // Arrange
            Rectangle r = new Rectangle(5, 4);

            // Act
            int result = r.Rect_Area();

            // Assert
            Assert.AreEqual(20, result); // 5*4 = 20
        }
    }
}