using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathFunktionen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFunktionen.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void Calc_ggTTest() //name des testsje to metoda co volame
        {

            //arrange
            int a = 39;
            int b = 70;
            // act
            int result = MyMath.Calc_ggT(39, 70);
            // Assert.Fail();
            //assert
            Assert.AreEqual(result, 1);

        }

        [TestMethod()]
        public void MaximumTest() //name des testsje to metoda co volame
        {

            //arrange
            int[] numbers = {4,6,9,10,34,27,299 };
            // act
            int result = MyMath.maximalWert(numbers);
            // Assert.Fail();
            //assert
            Assert.AreEqual(result, 299);

        }
    }
}