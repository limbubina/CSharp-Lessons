using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection15
{
    internal class MultiUnit : Housing, IUnits
    {
        private string complexName;
        private int numberofUnits;
        private decimal rentPerUnit;

        //constructor

        public MultiUnit(string complexName, int numberofUnits, decimal rentPerUnit, string multiUnitAddress, string multiUniTypeOfConstruction, int multiUnitYearBuilt)
            : base(multiUnitAddress, multiUniTypeOfConstruction, multiUnitYearBuilt)
        {
            ComplexName = complexName;
            NumberofUnits = numberofUnits;
            RentPerUnit = rentPerUnit;
        }

        //Properties
        public string ComplexName
        {
            get { return complexName; }
            set { complexName = value; }
        }

        public int NumberofUnits
        {
            get { return numberofUnits; }
            set { numberofUnits = value; }
        }

        public decimal RentPerUnit
        {
            get { return rentPerUnit; }
            set { rentPerUnit = value; }
        }

        //Override methods
        public override decimal ProjectRentalAmt()
        {
            return RentPerUnit * NumberofUnits * 12;
        }

        public int GetNumberofUnits()
        {
            return NumberofUnits;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n Name of a complex: {ComplexName}" +
                $"\n Number of units: {GetNumberofUnits()}" +
                $"\n Rent Per unit: {RentPerUnit.ToString("C")} " +
                $"\n Annual rent projected: {ProjectRentalAmt().ToString("C")}";
        }
    }
}
