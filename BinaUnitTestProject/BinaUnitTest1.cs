using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace BinaUnitTestProject
{

    [TestClass]
    [TestCategory("BinaLoginFeature")]
    public class BinaUnitTest_Part1
    {
        [TestMethod] 
        [TestCategory ("BinaPositiveTests")] //can be class level or methods level
        [Description("This are tests")] //only valid on test methods

        public void BinaTestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3,a+b);
            
     
        }

        [TestMethod]
        [TestCategory("BinaNegativeTests")]
        public void BinaTestMethod2()
        {
            var a = 5;
            Assert.IsTrue(a==5);
        }

        [TestMethod]    
        [Description ("Want the test to fail")]
        [TestCategory("BinaExtraTests")]
        [ExpectedException (typeof (AssertFailedException))]
        public void BinaTestMethod3()
        {
            var a = 5;
            Assert.AreNotEqual(5, a);//throws an exception if two values are equal
        }
    }

    
    /*.......................................................TEST.........................................................*/
    
    [TestClass]
    [TestCategory ("BinaQuiz)")]
    public class BinaUnitTest_Part2
    {
        
        [TestMethod]
        public void TestBina1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);

        }

        [TestMethod]
        public void TestBina2()
        {
           
            Assert.Fail("This test will always fail");

        }

        [TestMethod]
        [ExpectedException(typeof (AssertFailedException))]
        
        public void TestBina3()
        {
            var a = 10;
            var b = 10;

            //Assert.IsTrue(a + b == 21); //not clear error message
            Assert.AreEqual(21, a + b);

        }

    }
    [TestClass]
    [TestCategory("BinaPart3")]
    public class BinaUnitTest_Part3
    {
        private int a;
        private int b;
        public TestContext BinaTest3context { get; set; }
        //private static TestContext _bina_testContext; not needed 

        /*...............................Class Initilise & cleanup.............................................*/

        [ClassInitialize]
        public static void Bina_RunBeforeAllTestMethodsStarted(TestContext BinaTest3context) //BinaTest3context is what's stored as Testcontext
        {
           //_bina_testContext = BinaTest3context; it's just passing the same thing 
            Trace.WriteLine("I will run one time before all the tests in the class started)");
        }

        [ClassCleanup]
        public static void bina_RunAfterEveryTestClass()
        {
            Trace.Write("I will execute one time after all the tests in the class finished");
        }

        /*...............................Test Initilise & cleanup.............................................*/

        [TestInitialize]
        public void bina_RunBeforeEveryTest()
        { 
            a = 1;
            b = 2;
        }

        [TestCleanup]
        public void bina_RunAfterEveryTestMethod()
        {
            Trace.WriteLine("I will execute after every single test method in a class");// will output to the console everytime it's ran
        }

        

        /*................................Test Methods................................................*/

        [TestMethod]
        public void binaTestMethod1A()
        {
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void binaTestMethod2A()
        {
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void binaTestMethod3A()
        {
            Assert.AreNotEqual(1, a);//throws an exception if two values are equal
        }
    }


}
/*.......................................................TEST2.........................................................*/




