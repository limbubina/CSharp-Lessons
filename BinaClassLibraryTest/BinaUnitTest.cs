using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaClassLibraryTest
{
    [TestClass]
    public class BinaUnitTest
    {
        [TestMethod]
        public void BinaTestMethod1()
        {
            int testResult  = ClassLibraryPractice.Class1.Addition(5, 5);
            Assert.AreEqual(10,testResult);
        }
    }
}
