using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section6
{
    [TestClass]
    public class TripUnitTest
    {

        [TestMethod]
        public void Test_MilesPerGallon()
        {
            Trip myTrip = new Trip("Italy", 100, 150, 10);

            int milesPerGallon = myTrip.milesPerGallon();
            Assert.AreEqual(10, milesPerGallon);
        }

        [TestMethod]
        public void Test_CostPerMile()
        {
            Trip myTrip = new Trip("Italy", 120, 155.3850M, 10);

            Assert.AreEqual(1.295M, myTrip.costPerMile());
        }

        [TestMethod]
        public void Test_OverrideString()
        {
            Trip myTrip = new Trip("Italy", 100, 150M, 10);

            string actualString = myTrip.ToString();
            Console.WriteLine(actualString);

            string overiddenString = "Destination: Italy, " +
                "\nDistance travelled: 100, " +
                "\nCost of Gas: £150.00, " +
                "\nTotal gallon: 10";
            
            Assert.AreEqual(overiddenString, actualString);

        }
    }
}
