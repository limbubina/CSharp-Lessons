using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BinaSection15
{
    [TestClass]
    public class HousingApplicationTest
    {
        [TestMethod]
        public void Test_SingleFamily()
        {
            SingleFamily SingleFamily1 = new SingleFamily(500, 200, 1, 1, true, false, "9 royston", "Brick", 1991);
            SingleFamily SingleFamily2 = new SingleFamily(600, 300, 2, 2, false, true, "12 Driveway", "Mortar", 1992);
            SingleFamily SingleFamily3 = new SingleFamily(700, 400, 3, 1, false, false, "22 Greencroft", "Wood", 1993);
            SingleFamily SingleFamily4 = new SingleFamily(800, 500, 4, 2, true, true, "200 road", "Timber", 1994);
            SingleFamily SingleFamily5 = new SingleFamily(900, 600, 5, 1, true, false, "56 Wayoak", "Stone", 1995);

            List<SingleFamily> singleFamilyList = new List<SingleFamily>();
            singleFamilyList.Add(SingleFamily1);
            singleFamilyList.Add(SingleFamily2);
            singleFamilyList.Add(SingleFamily3);
            singleFamilyList.Add(SingleFamily4);
            singleFamilyList.Add(SingleFamily5);

            foreach (SingleFamily f in singleFamilyList)
            {
                Console.WriteLine(f);
            }
        }
        [TestMethod]
        public void Test_MultiUnit()
        {
            MultiUnit MultiUnit1 = new MultiUnit("Apartment", 2, 300.00M, "Aprtment1 Road", "Brick", 2000);
            MultiUnit MultiUnit2 = new MultiUnit("Complex", 3, 400.00M, "12 Complex", "Mortar", 2002);
            MultiUnit MultiUnit3 = new MultiUnit("Duplex", 4, 600.00M, "22 Duplex", "Wood", 2003);
            MultiUnit MultiUnit4 = new MultiUnit("Studio", 1, 700.00M, "200 Studio", "Timber", 2006);
            MultiUnit MultiUnit5 = new MultiUnit("Pent House", 3, 1000.00M, "56 Pent House", "Stone", 2010);

            List <MultiUnit> multiUnitList = new List<MultiUnit>();
            multiUnitList.Add(MultiUnit1);
            multiUnitList.Add(MultiUnit2);
            multiUnitList.Add(MultiUnit3);
            multiUnitList.Add(MultiUnit4);
            multiUnitList.Add(MultiUnit5);

            foreach(MultiUnit f in multiUnitList)
            {
                Console.WriteLine(f);
            }
        }

        [TestMethod]
        public void Test_Combined()           
        {
            SingleFamily SingleFamily1 = new SingleFamily(500, 200, 1, 1, true, false, "9 royston", "Brick", 1991);
            SingleFamily SingleFamily2 = new SingleFamily(600, 300, 2, 2, false, true, "12 Driveway", "Mortar", 1992);
            SingleFamily SingleFamily3 = new SingleFamily(700, 400, 3, 1, false, false, "22 Greencroft", "Wood", 1993);
            SingleFamily SingleFamily4 = new SingleFamily(800, 500, 4, 2, true, true, "200 road", "Timber", 1994);
            SingleFamily SingleFamily5 = new SingleFamily(900, 600, 5, 1, true, false, "56 Wayoak", "Stone", 1995);

            MultiUnit MultiUnit1 = new MultiUnit("Apartment", 2, 300.00M, "Aprtment1 Road", "Brick", 2000);
            MultiUnit MultiUnit2 = new MultiUnit("Complex", 3, 400.00M, "12 Complex", "Mortar", 2002);
            MultiUnit MultiUnit3 = new MultiUnit("Duplex", 4, 600.00M, "22 Duplex", "Wood", 2003);
            MultiUnit MultiUnit4 = new MultiUnit("Studio", 1, 700.00M, "200 Studio", "Timber", 2006);
            MultiUnit MultiUnit5 = new MultiUnit("Pent House", 3, 1000.00M, "56 Pent House", "Stone", 2010);

            List <Housing> HousingList = new List<Housing>();

            HousingList.Add(MultiUnit1);
            HousingList.Add(MultiUnit2);
            HousingList.Add(MultiUnit3);
            HousingList.Add(MultiUnit4);
            HousingList.Add(MultiUnit5);
            HousingList.Add(SingleFamily1);
            HousingList.Add(SingleFamily2);
            HousingList.Add(SingleFamily3);
            HousingList.Add(SingleFamily4);
            HousingList.Add(SingleFamily5);

            foreach(Housing f in HousingList)
            {
                Console.WriteLine($"\n Address: {f.Address}" +
                    $"\n Projected Rental amount: {f.ProjectRentalAmt().ToString("C")}");
            }
        }
    }
}
