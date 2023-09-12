using Bina_Section6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section7
{
    [TestClass]
    public class ReceiptUnitTest
    {
        [TestMethod]
        public void ValidReceiptNumber()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(2, testReceipt.ReceiptNumber);
        }
        [TestMethod]
        public void ValidCustomerNumber()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(100, testReceipt.CustomerNumber);
        }
        [TestMethod]
        public void ValidItemNumer()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 1000, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(1000, testReceipt.ItemNumber);
        }

        [TestMethod]
        public void ValidUnitPrice()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 100.75M, 55);
            Assert.AreEqual(100.75M, testReceipt.ItemUnitPrice);
        }
        [TestMethod]
        public void ValidQuantityPurchased()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 7);
            Assert.AreEqual(7, testReceipt.QuantityPurchased);
        }

        //Invalid Test Methods

        [TestMethod]
        [ExpectedException (typeof(ArgumentException), "Receipt number is 0 or less than 0")]
        public void InvalidReceiptNumber()
        {
            Receipt testReceipt = new Receipt(-2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(0, testReceipt.ReceiptNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCustomerNumber()
        {
            Receipt testReceipt = new Receipt(-2, "22-March-2022", 0, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(0, testReceipt.CustomerNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidItemNumer()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 10000, "This is test for item1", 5.25M, 55);
            Assert.AreEqual(10000, testReceipt.ItemNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidUnitPrice()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 10000M, 55);
            Assert.AreEqual(10000M, testReceipt.ItemUnitPrice);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InalidQuantityPurchased()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M,0);
            int actualValue = testReceipt.QuantityPurchased;
            Assert.AreEqual(0, actualValue);
        }
        [TestMethod]
        public void CallOverrideString()
        {
            Receipt testReceipt = new Receipt(2, "22-March-2022", 100, "Bina", "Limbu", "United Kingdom", "07898766223", 98, "This is test for item1", 5.25M, 10);
            Console.WriteLine(testReceipt.ToString());

            //string actualResult = testReceipt.ToString();           
            //Assert.AreEqual($"Bina Limbu, 7898766223, {52.5:C}",actualResult);
        }
    }
}
