using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section6
{
    [TestClass]
    public class BinaCarTest2
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            BinaCar2 mycar = new BinaCar2("Red", 2, true);

            //act


            //assert
            //StringAssert.Equals(mycar.Colour, "Re b");
            Assert.Equals( "Red",mycar.Colour);
        }

        [TestMethod]

        public void Call_Accelerate_Method()
        {

            BinaCar2 mycar = new BinaCar2("Red", 2, true);

            mycar.Accelerate();

        }

        [TestMethod]

        public void Call_FamilyCar_Method()
        {
            //arrange
            BinaCar2 mycar = new BinaCar2("Black", 4, false);

            //act
            bool carType = mycar.FamilyCar();

            //assert
            if(carType == true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}
