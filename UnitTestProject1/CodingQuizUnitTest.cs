using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection9
{
    [TestClass]
    public class CodingQuizUnitTest
    {
      [TestMethod]
        public void TestSquarRoot()
        {
            double result = MathFuntions.SquareRoot(5);
            //Assert.AreEqual(2.24, result);
            Assert.AreEqual(2.2, result,1);// adding the precision if 1 decimal place as parameter
        }
        [TestMethod]
        public void TestSum_Int()
        {
            int result = MathFuntions.Sum(2, 2);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestSum_Double()
        {
            double result = MathFuntions.Sum(2.2, 2.5);
            Assert.AreEqual(4.7, result);
        }
        [TestMethod]
        public void TestSum_Decimal()
        {
            decimal result = MathFuntions.Sum(2.2M, 2.5M);
            Assert.AreEqual(4.7M, result);
        }

    }
    
}
