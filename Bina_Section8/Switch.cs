using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section8
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void Test_Switch_Stataments()
        {
            //not a loop
            //multiple choices

            int weekDay = 4;
            string testDay = "";

            //weekday is the vlaue we want to evaluate in ou rmultiple choice question 
            // for each one of the possible value that this variable might be, we create a Case
            // 

            switch (weekDay)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay= "Friday";
                    break;

                default: 
                    testDay = "Not Mon - Fri";
                    break;
            }

            Assert.AreEqual("Thursday",testDay);



        }
    }
}
