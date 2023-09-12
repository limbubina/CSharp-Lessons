using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection5_Integers
{
    [TestClass]
    [TestCategory ("Bina Integer Operations")]
    public class BinaIntegerOperatons
    { 
        //variables to hold the two integer values
        static int number1;
        static int number2;

        [ClassInitialize]
        public static void IntegerInitialize(TestContext testcontext)
        {
            //set the values of the two number  we'll be using
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Bina_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum,15);

        }

        [TestMethod]
        public void Bina_Subration()
        {
            int difference = number1 - number2; 
            Assert.AreEqual(5,difference);
        }

        [TestMethod]
        public void Bina_Muiltiplication()
        {
            int product = number1 * number2;
            Assert.AreEqual(50, product);
        }

        [TestMethod]
        public void Bina_Division()
        {
            int quotient = number1 / number2;
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        public void Bina_Modulus()
        {
            int remainder = number1% number2;
            Assert.AreEqual(0, remainder);
        }

    }
}
