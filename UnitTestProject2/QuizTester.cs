using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13.Quiz

{
    [TestClass]
    public class QuizTester

        //modify test to catch three different exceptions:
        //ArithmeticException
        //FormatException
        //Exception
        //Use one try block to accomlish this task
    {
        [TestMethod]
        public void Calculate_BMI()
        {
            //setup variables to calculate BMI
            string weight = "150";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;
            try
            {
                //create instance of the BodyMassIndexCalcualtor, pass over all variables
                 bmi = new BodyMassIndexCalculator(int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));
                            
            }
           
            catch (ArithmeticException arithmeticEx)
            {
                Console.WriteLine("Arithmetic Exception: "+ arithmeticEx.Message);
            }


            catch (FormatException formatEx)
            {
                Console.WriteLine("Format Excpetion: "+ formatEx.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("Excpetion: "+ ex.Message);
            }
            //get result
            string result = bmi.ToString();

            //create assertion
            Assert.AreEqual("BMI: 5.09", result);


        }
    }
}
