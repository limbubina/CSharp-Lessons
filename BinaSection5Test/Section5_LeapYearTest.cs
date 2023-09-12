using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection5Test
{
    [TestClass]
    [TestCategory("LeapYear Exam")]

    public class Section5_LeapYearTest 
    
    {
        public TestContext TestContext { get; set; }

        public bool LeapYearCheck(int givenYear)
        {
            bool isLeapYEar = true;

            //Console.WriteLine("Enter a Year");
            //string userYear = Console.ReadLine();
            //givenYear = Convert.ToInt32(userYear);

            if (givenYear % 4 == 0)
            {
                Console.WriteLine("Divisible  by 4: Yes");

                if (givenYear % 4 == 0 && givenYear % 100 == 0 && givenYear % 400 == 0)
                {
                   Console.WriteLine("Divisible  by 4: Yes");
                   Console.WriteLine("Divisible  by 100: Yes");
                   Console.WriteLine("Divisible  by 400: Yes");
                   isLeapYEar = true;
                }

            }
            else
            {
                isLeapYEar = false;
            }
            
            return isLeapYEar;
        }

        [TestMethod]

        public void LeapYearTest1()
        {
            bool result = LeapYearCheck (2020);
            if (result == true)
            {
                Assert.AreEqual(true, result);
                TestContext.WriteLine("This is leap year");
            }
            else 
            {
                Assert.Fail($"It is not a leap year");

            }

        }


       

        
    }
}

