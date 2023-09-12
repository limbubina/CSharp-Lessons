using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection9
{
    [TestClass]
    public class PropertyTax_UnitTest
    {
        [TestMethod]
        public void Test_Current_Value()
        {
            PropertyTaxExam myTax = new PropertyTaxExam("Bahamas", 450000M, 500000M);
            decimal exemptionValue = myTax.Calculate_Current_Value();

            Assert.AreEqual(475000M, exemptionValue);
        }

        [TestMethod]
        public void Test_Tax_Due()
        {
            PropertyTaxExam myTax = new PropertyTaxExam("Bahamas", 450000M, 500000M);
            decimal taxValue = Math.Round(myTax.Calculate_Taxes_Due(),2);

            Assert.AreEqual(4764.25M, taxValue);
        }

        [TestMethod]
        public void Address1()
        {
            PropertyTaxExam myTax = new PropertyTaxExam("UK", 350000M, 400000M);
            Console.WriteLine(myTax);
        }

        [TestMethod]
        //can write 3 constructores under 1 methods!
        public void Test_String_Output()
        {
            PropertyTaxExam home1 = new PropertyTaxExam("England", 110000M, 115000M);
            Console.WriteLine(home1);

            PropertyTaxExam home2 = new PropertyTaxExam("Wales", 550000M, 600000M);
            Console.WriteLine(home2);

            PropertyTaxExam home3 = new PropertyTaxExam("Wales", 550000M, 600000M);
            Console.WriteLine(home3);
        }

        [TestMethod]
        public void Test_New_Assessed_Value()
        {
            PropertyTaxExam myTax = new PropertyTaxExam("Wales", 110000M, 120000M);
            decimal newValue = myTax.Calculate_New_Assessed_Value();
            Console.WriteLine(newValue);
        }
    }
}
