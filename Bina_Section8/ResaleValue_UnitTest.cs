using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bina_Section8
{
    /// <summary>
    /// Summary description for ResaleValue_UnitTest
    /// </summary>
    [TestClass]
    public class ResaleValue_UnitTest
    {

        [TestMethod]
        public void Test_ItemPrice()
        {
            ResaleValue myResaleValue = new ResaleValue(100M);
            decimal itemPrice = myResaleValue.ItemPrice;

            //header row for tabular format
            Console.WriteLine(String.Format("{0, -20} {1,-20} {2, -20}", "Old Price", "Increase %", "New Price"));
         

            decimal markUpValue;
            decimal newPrice = 0M;

            for (markUpValue = 5M; markUpValue <= 10M; markUpValue++)
            {
                newPrice = ((markUpValue / 100) * itemPrice) + itemPrice;
                string output = (String.Format("{0, -20:C} {1, 5} {2, 22:C}", itemPrice, markUpValue, newPrice));
                Console.WriteLine(output);
               
            }


        }
    }
}
