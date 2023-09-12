using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTest__UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int result = ClassLibraryPractice.Class1.Addition(10, 5); // Addition is the method, Class1 is Class, classlibraryPractice is namespace
            Assert.AreEqual(result, 15); //15 is expected result

        }
    }
}
