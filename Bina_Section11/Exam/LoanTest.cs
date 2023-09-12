using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section11.Exam
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void Test_Auto_Loan()
        {
            AutoLoan myAutoLoan = new AutoLoan(12, "Bina", "Limbu", 7.5, 12000M, 4, 2020, "F-Pace", "Jaguar", "Blue");
            Console.WriteLine(myAutoLoan);

            Assert.AreEqual(2031.25M, myAutoLoan.CalculateInterest());

        }

        [TestMethod]
        public void Test_Home_Loan()
        {
            HomeLoan myHomeLoan = new HomeLoan(19, "Josh", "Ray", 3.5, 210000M, 30,"Nottingham",1980,21.4);
            Console.WriteLine(myHomeLoan);

            Assert.AreEqual(20.90M,myHomeLoan.CalculateInterest());

        }
    }
}
