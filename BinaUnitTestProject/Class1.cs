using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace BinaAlternative

{
    [TestClass]
    [TestCategory("Check")]
    public class BinaUnitTest_Part3
    {
        private int a;
        private int b;
        public TestContext BinaTest3context { get; set; }
        //private static TestContext _bina_testContext;

        /*...............................Class Initilise & cleanup.............................................*/

        [ClassInitialize]
        public static void Bina_RunBeforeAllTestMethodsStarted(TestContext BinaTestcontext)
        {
           // _bina_testContext = BinaTestcontext;
            Trace.WriteLine("I will run one time before all the tests in the class started)");
        }

        [TestMethod]
        public void BinaCheck()
        {
            a = 5;
            b = 5;
            Assert.AreEqual(10, a + b);
        }
    }
}
