using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection9
{
    internal class PropertyTaxExam
    {
        //private string propertyAddress;
        //private decimal lastYearValue;
        //private decimal currentYearValue;
        private int exemption = 25000;
        private decimal millageRate = 10.03M;
        private decimal increaseValue = 2.7M;

        //constructor
        public PropertyTaxExam(string propertyAddress, decimal lastYearValue, decimal currenYearValue)
        {
            PropertyAddress = propertyAddress;
            LastYearValue = lastYearValue;
            CurrentYearValue = currenYearValue;

        }

        //properties

        public string PropertyAddress { get; set; }
        public decimal LastYearValue { get; set; }

        public decimal CurrentYearValue { get; set; }

        //Methods

        //Calculate new assessed value
        //2.7% of th eprevious ytear value or current year value??
        public decimal Calculate_New_Assessed_Value()
        {
            decimal newValue = (increaseValue / 100 * LastYearValue) + LastYearValue;
            return newValue;
        }

        //Calculate currennt year valuation
        public decimal Calculate_Current_Value()
        {
            decimal currentValue = CurrentYearValue - exemption;
            return currentValue;
        }

        //calculate tax value for the current year
        public decimal Calculate_Taxes_Due()
        {
            decimal currentTaxValue = (millageRate / 1000) * Calculate_Current_Value();
            return currentTaxValue;
        }

        //override string
        public override string ToString()
        {
            return $"Property Address:{PropertyAddress}" +
                $"\nLast Year Assessed Value: {LastYearValue:C}" +
                $"\nCurrent Assesed Value:{CurrentYearValue:C}" +
                $"\nExemption: {25000:C}" +
                $"\nTaxable Value: {Calculate_Current_Value():C}" +
                $"\nMillage Rate (per £1000): {10.03:C}" +
                $"\nTaxes Due: {Calculate_Taxes_Due():C}\n";
        }
    }
}
