using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section8
{
    [TestClass]
    public class DoWhile
    {
        [TestMethod]
        public void Test_Do_While()
        {
            //Post test loop
            //Loops just once
            //test condition and decide if we want to loop anymore
            int sum = 0;
            int number = 1;
            do
            {
                sum += number;
                number++;

            }
            while (number <= 10);

            Assert.AreEqual(55, sum);



        }
    }
}
