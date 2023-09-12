using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection15.EndExam
{
    [TestClass]
    public class PageTest
    {
        [TestMethod]
        public void Test_ComplicatedPage()
        {
            ComplicatedPage complicatedPage1 = new ComplicatedPage();
            string pageName = complicatedPage1.PageName;

            Assert.AreEqual("Complicated Page", pageName);
        }

        [TestMethod]

        public void Test_SectionOfRandomStuff()
        {
            SectionOfRandomStuff sectionOfRandomStuff = new SectionOfRandomStuff();
            sectionOfRandomStuff.FillForm();
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))] //expect and exception

        public void Test_SectionOfButton()
        {
            SectionOfButtons sectionOfButtons = new SectionOfButtons();
           //Element test = new Element();
            //sectionOfButtons.Button.test.Click();

            Console.WriteLine("Null referece to the button Element"); //or you can create class Element as Abstract class

        }


    }
}
