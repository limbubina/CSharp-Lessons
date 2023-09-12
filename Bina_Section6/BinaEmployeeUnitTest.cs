using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Bina_Section6
{
    [TestClass]
    public class BinaEmployeeUnitTest
    {
     
        [TestMethod]
        public void SpaceName_Test()
        {
            BinaEmployee myEmployee = new BinaEmployee("Bina", "Limbu");
            string fullNametest = myEmployee.FullName();           
            Assert.AreEqual("Bina Limbu", fullNametest);
            
        }

        [TestMethod]
        public void SortedName_Test()
        {
            BinaEmployee myEmployee2 = new BinaEmployee("Bina", "Limbu");
            string fullNametest2 = myEmployee2.SortedName();
            //Trace.WriteLine("binaTest " + fullNametest2);
            Assert.AreEqual("Limbu, Bina", fullNametest2);
        }
    }
}
