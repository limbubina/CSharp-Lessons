using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection9
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void firstLastName_Method()
        {
            //arrange

            EmployeeClass myEmployee = new EmployeeClass("Bina", "Limbu");

            Assert.AreEqual("Bina Limbu", myEmployee.Sort1());
        }

        [TestMethod]
        public void lastFirstName_Method()
        {
            EmployeeClass myEmployee = new EmployeeClass("Bina", "Limbu");
            string result = myEmployee.Sort2();

            //StringAssert.Equals(result, "LimbuBina"); --doesn't work!
            Assert.AreEqual("Limbu, Bina", result);

        }

        [TestMethod]
        public void Test_Employee()
        {
            EmployeeClass myEmployee = new EmployeeClass("Joe", "Roe");

            myEmployee.Title = "HR"; //calling properties and assigning value without initialising in the object above

            string jobLocation = myEmployee.JobLocation();
            Assert.AreEqual("Chicago", jobLocation);
        }

        [TestMethod]
        public void Test_Employee_Location()
        {
            EmployeeClass myEmployee = new EmployeeClass("Bina", "Limbu", 510, "Manager");

            string location = myEmployee.JobLocation();
            Assert.AreEqual("Boston", location);

        }

        [TestMethod]
        public void ToString_Test()
        {
            EmployeeClass employee = new EmployeeClass("Sara", "Fin", 1234, "Manager");
            Console.WriteLine(employee);
        }

        //Method overlaoding

        [TestMethod]
        public void Test_Employee_Overload_string()
        {
            EmployeeClass myEmployee = new EmployeeClass("Sara", "Fin", 1234, "Manager");
            string result = myEmployee.PayType(myEmployee.Title);
            Console.WriteLine(result);

        }

        [TestMethod]
        public void Test_Employee_Overload_Int()
        {
            EmployeeClass myEmployee = new EmployeeClass("Sara", "Fin", 1234, "Manager");
            string result = myEmployee.PayType(myEmployee.EmployeeId);

            Console.WriteLine(result);
        }
    }
}
