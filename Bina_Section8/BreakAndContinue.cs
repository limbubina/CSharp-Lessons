using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section8
{
    [TestClass]
    public class BreakAndContinue
    {
        [TestMethod]
        public void Break_Keyword()
        {

            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;//jumps out of the (For) loop statement when it reaches the specified condition
                }
                total += nValue;
            }

            Assert.AreEqual(10, total);

        }


        [TestMethod]
        public void Continue_Keyword()
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    continue;// won't jump out of the loops
                }
                total += nValue;
            }

            Assert.AreEqual(40, total);


        }
    }
}
