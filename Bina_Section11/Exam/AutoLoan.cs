using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11.Exam
{
    internal class AutoLoan:Loan
    {

        private int yearBuilt;
        private string model;
        private string make;
        private string colour;

        public AutoLoan(int autoLoanNumber, string autoCustomerFirstName, string autoCustomerLastName,
            double autoInteresRate, decimal autoLoanAmount, int autoYearInLoanTerm, int yearBuilt, string model, string make, string colour)          
            : base(autoLoanNumber, autoCustomerFirstName, autoCustomerLastName,
            autoInteresRate, autoLoanAmount, autoYearInLoanTerm)
        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Colour = colour;                 
        }

        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        //override string
        public override string ToString()
        {
            string autoLoanInfo = $"\nThis is auto loan." +
                $"\nCar built: {YearBuilt}" +
                $"\nCar make: {Make}" +
                $"\nCar model: {Model}" +
                $"\nCar colour: {Colour}";

            return base.ToString() + autoLoanInfo + "\nAutoloan Interest amount: " + CalculateInterest().ToString("C");
        }

        //calculate interest

        public override decimal CalculateInterest()

        {
            decimal autoInterest = (Convert.ToDecimal(InterestRate) / (YearInLoanTerm * 12)) * (LoanAmount + 1000);
            decimal RoundUpResult = Math.Round(autoInterest, 2);
            return RoundUpResult;
        }
    }
}
