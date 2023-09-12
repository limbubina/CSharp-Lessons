using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class ExamTests

    //create a try catch block in each test that calls the method and catches the specific
    //exception that is produced. Each method should be handles
    //so that if an exception occurs the test will still pass.
    //writ eout the error message that occurs so you can view it in the output

    {
        [TestMethod]
        public void Test_WeeklyWage()
        {
            try
            {
                ExamHelper.WeeklyWages();
                //Assert.AreEqual(2, ExamHelper.WeeklyWages());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error in loop termination condition" + "\n" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        [TestMethod]
        public void Test_Calc_Resukt()
        {
            try
            {
                ExamHelper.CalcualteResult();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error in parameter type" + "\n" + ex.Message);
            }
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine("Arithmetic excpetion thrown" + "\n" + ex.Message);
            }

        }

    }
}
