using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section6
{
    [TestClass]
    public class BinaCarTest
    {
        [TestMethod]
        public void Class_Car_Colour_Set()
        {
            //arrange - Create a new car using BinaCar constructor
            BinaCar myCar = new BinaCar("red", 2, true);

            //act


            //assert
            StringAssert.Equals(myCar.Colour, "red"); //is that colour equal to red?
        }
    }
}
