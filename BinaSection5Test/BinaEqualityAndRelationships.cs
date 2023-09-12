using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection5_EqualAndRelationships
{
    [TestClass]
    [TestCategory("Bina Operators")]

    //Operators
    //==, !=, <, >, <=, <=, 
    public class EqualitAndRelationship
    {
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegrerInitlise(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;

        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Number1_EqualsTo_Number2()
        {
            if (number2 == number1)
            {
                //this block code only executes if the condition is true
                Assert.IsTrue(number1 == number2);
            }
            else
            {
                //this code is executed if the 'if' statement is false
                //Assert.IsFalse(number1 == number2);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Number1_NotEqualsTo_Number2()
        {
            Assert.IsTrue(number1 != number2);
        }

        [TestMethod]
        public void Number1_GreaterThan_Number2()
        {
            if (number1 >= number2)
            {

                Assert.IsTrue(number1 >= number2);
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}
