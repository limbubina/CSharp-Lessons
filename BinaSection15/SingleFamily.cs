using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection15
{
    internal class SingleFamily : Housing
    {
        private decimal rentAmount;
        private double unitSize;
        private int numberOfBedroom;
        private int numberOfBathroom;
        private bool hasPorch;
        private bool hasGarage;

        public SingleFamily(decimal rentAmount, double unitSize, int numberOfBedroom, int numberOfBathroom, bool hasPorch, bool hasGarage, string singleHouseAddress, string singleHouseTypeOfConstruction, int singleHouseYearBuilt)
       : base(singleHouseAddress, singleHouseTypeOfConstruction, singleHouseYearBuilt)
        {
            RentAmount = rentAmount;
            UnitSize = unitSize;
            NumberOfBedroom = numberOfBedroom;
            NumberOfBathroom = numberOfBathroom;
            HasPorch = hasPorch;
            HasGarage = hasGarage;
        }

        //properties
        public decimal RentAmount
        {
            get { return rentAmount; }
            set { rentAmount = value; }
        }

        public double UnitSize
        {
            get { return unitSize; }
            set { unitSize = value; }
        }
        public int NumberOfBedroom
        {
            get { return numberOfBedroom; }
            set { numberOfBedroom = value; }
        }
        public int NumberOfBathroom
        {
            get { return numberOfBathroom; }
            set { numberOfBathroom = value; }
        }

        public bool HasPorch
        {
            get { return hasPorch; }
            set { hasPorch = value; }
        }      

        public bool HasGarage
        {
            get { return hasGarage; }
            set { hasGarage = value; }
        }

        public override decimal ProjectRentalAmt()
        {
            return RentAmount * 12M;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n Number of bedroom: {NumberOfBedroom}" +
                $"\n Number of bathroom: {NumberOfBathroom}" +
                $"\n Does the house have Porch: {HasPorch}" +
                $"\n Does the house have Garage: {HasGarage}" +
                $"\n Monthly Rental rate: {RentAmount.ToString("C")}"+
                $"\n Annaul amount: {ProjectRentalAmt().ToString("C")}";
        }
    }
}
