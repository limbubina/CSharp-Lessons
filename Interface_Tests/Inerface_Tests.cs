using Interface_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interface_Exams
{
    [TestClass]
    public class Inerface_Tests
    {
        [TestMethod]
        public void Test_Page1()
        {
           IPageObject pageObject1 = new PageObjectOne();        
           Assert.AreEqual(pageObject1.PageName, "Page Name 1");
                
        }
        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");

        }
    }
}
