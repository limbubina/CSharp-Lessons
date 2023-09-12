using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Section13
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void Test_Exception()
        {
            int totalScores = 10;
            int countofScore = 0;

            double average = totalScores / countofScore;


        }

        [TestMethod]

        public void Test_Division()
        {
            ExceptionHelper.DivisionTest();
        }

        [TestMethod]
        public void Test_StateCheck()//using try catch passess the test as it's handling the error
        {
            try
            {
                ExceptionHelper.CheckStateOk("MA");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
