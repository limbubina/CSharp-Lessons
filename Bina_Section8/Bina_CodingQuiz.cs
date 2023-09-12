using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bina_Section8
{
    [TestClass]
    public class Bina_CodingQuiz
    {
        [TestMethod]
        public void LoopQuiz()
        {
            int outerNumber = 0;
            int innerNumber = 10;

            while (outerNumber <= 2)

            //int innerNumber = 10 //you can declare inner variable here instead of incrementing it afte the loop
            {
                while (innerNumber > 5)
                {
                    Console.WriteLine($"Outer:{outerNumber}\tInner:{innerNumber}");
                    innerNumber--;
                }
                outerNumber++;
                innerNumber += 5;
            }
        }

    }
}

