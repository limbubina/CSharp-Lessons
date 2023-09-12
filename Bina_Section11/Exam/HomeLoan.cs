using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11.Exam
{
    internal class HomeLoan : Loan
    {
        private string homeAddress;
        private int yearBuilt;
        private double squareFootage;

        //Constructor
        public HomeLoan(int homeLoanNumber, string homeCustomerFirstName, string homeCustomerLastName,
            double homeInteresRate, decimal homeLoanAmount, int homeYearInLoanTerm, string homeAddress, int yearBuilt, double squareFootage)
            : base(homeLoanNumber, homeCustomerFirstName, homeCustomerLastName,
             homeInteresRate, homeLoanAmount, homeYearInLoanTerm)
        {
            HomeAddress = homeAddress;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        //Properties of HomeLoan
        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }

        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public double SquareFootage
        {
            get { return squareFootage; }
            set { squareFootage = value; }
        }

        public override string ToString()
        {
            string homeLoanInfo = $"\nThis is home loan." +
            $"\nAddress: {HomeAddress}" +
            $"\nYear built: {yearBuilt}" +
            $"\nArea: {SquareFootage} square footage";

            return base.ToString() + homeLoanInfo + "\nHomeloan Interest amount: " + CalculateInterest().ToString("C");
        }

        //Calcualte home itnerest amount
        public override decimal CalculateInterest()

        {
            decimal homeInterest = (Convert.ToDecimal(InterestRate/100) / (YearInLoanTerm * 12)) * (LoanAmount + 5000);          
            
            //rounding up to 0 decimal places
            decimal RoundUpResult = Math.Round(homeInterest, 2);
           
            return RoundUpResult;
        }
    }
}
