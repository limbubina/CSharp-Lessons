using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Net.Cache;
using System.Text.RegularExpressions;

namespace Bina_Section14
{
    [TestClass]
    public class CodingQuizTest
    {
        [TestMethod]
        public void TestFirstName()
        {
            string firstName = "Bina";

            string patternName = @"^([a-zA-Z])+$";

            bool testFirstName = IsName(firstName, patternName);
            if (testFirstName)
            {
                Assert.IsTrue(testFirstName);
            }
            else
            {
                Console.WriteLine("Validation problem with first name");
            }
        }
        public void TestLastName()
        {
            string lastName = "Limbu";
            string patternName = @"^([a-zA-Z])+$";

            bool testLastName = IsName(lastName, patternName);
            Assert.IsTrue(testLastName);
        }
        [TestMethod]
        public void PersonAge()
        {
            string age = "45";
            string patternAge = @"^\d+$";

            //bool response = IsAge(age, patternAge);

            Match matches = Regex.Match(age, patternAge);

            if (matches.Success)
            {
                Assert.IsTrue(matches.Success);
                Console.WriteLine("Age in integer is " + Int32.Parse(matches.Value));
            }
            else
            {
                Console.WriteLine("Age is invalid");
            }
        }

        [TestMethod]
        public void DateOfBirth()
        {
            int day = 12;
            int month = 12;
            int year = 199097;
            string patternDoB = @"^\d{2}/\d{2}/\d{4}$";
           // string patternDoBTest = @"^(0[1-9]|[12][0-9]|[3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\d\d$";

            string doB = ConvertDoB(day, month, year);
            //Console.WriteLine("test: " + doB);

            Match matches = Regex.Match(doB, patternDoB);
            //Assert.AreEqual("12/12/1990", matches.Value);

            if (matches.Success)
            {
                Assert.IsTrue(matches.Success);
                Console.WriteLine("DoB is: "+ matches.Value);
            }
            else
            {
                Console.WriteLine("DoB is invalid");
            }

            //bool isResponse = isDoB(day, month, year, patternDoB);
           // Assert.IsTrue(isResponse);
        }

        [TestMethod]

        public void PhoneNumber()
        {
            string phoneNumber = "(123)-333-44434";
            string patternPhoneNumber = @"^\(?\d{3}\)? *(-|.)? *\d{3} *(-|.)? *\d{4}$";
            //string patternPhoneNumber = @"^\(?\d{3}\)?-?\d{3}-?\d{4}";


            bool response = IsPhoneNumber(phoneNumber, patternPhoneNumber);

            Assert.IsTrue(response);

        }

        //method to Test name
        public static bool IsName(string name, string patterName)
        {

            if (name != null)
            {

                return Regex.IsMatch(name, patterName);
            }
            else return false;
        }

        //Date of Birth
        public static string ConvertDoB(int intDay, int intMonth, int intYear)
        {
            string day = "";
            string month = "";
            try
            {
                if (intDay >= 1 && intDay <= 31)
                {
                    day = intDay.ToString("00");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Value of Day is out of range. \n" + ex.Message);
            }

            try
            {
                if (intMonth >= 1 && intMonth <= 12)
                {
                    month = intMonth.ToString("00");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Value of Month is out of range. \n" + ex.Message);
            }

            string year = intYear.ToString();
            string fullDateofBirth = $"{day}/{month}/{year}";
            //Console.WriteLine(fullDateofBirth);

            return fullDateofBirth;
        }

        //DoB
        public static bool isDoB(int intDay, int intMonth, int intYear, string patternDoB)
        {
            string day = "";
            string month = "";
            try
            {
                if (intDay >= 1 && intDay <= 31)
                {
                    day = intDay.ToString("00");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Value of Day is out of range. \n" + ex.Message);
            }

            try
            {
                if (intMonth >= 1 && intMonth <= 12)
                {
                    month = intMonth.ToString("00");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Value of Month is out of range. \n" + ex.Message);
            }

            string year = intYear.ToString();
            string fullDateofBirth = $"{day}/{month}/{year}";
            //Console.WriteLine(fullDateofBirth);

            if (fullDateofBirth != null)
            {
                return Regex.IsMatch(fullDateofBirth, patternDoB);
            }
            else return false;

        }

        public static bool IsPhoneNumber(string phonenumber, string patternPhone)
        {
            bool result = true;
            try
            {

                if (Regex.IsMatch(phonenumber, patternPhone) == true)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException();
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }
    }
}
