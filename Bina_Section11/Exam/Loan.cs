using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11.Exam
{
    abstract class Loan
    {
        private int loanNumber;
        private string customerFirstName;
        private string customerLastName;
        private double interestRate;
        private decimal loanAmount;
        private int yearInLoanTerm;

        //Constructor
        public Loan (int loanNumber, string customerFirstName, string customerLastName, double interestRate, decimal loanAmount, int yearInLoanTerm)
        {
            LoanNumber = loanNumber;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            InterestRate = interestRate;
            LoanAmount = loanAmount;
            YearInLoanTerm = yearInLoanTerm;
        }

        //Properties
        public int LoanNumber
        {
            get { return loanNumber; }
            set { loanNumber = value; }
        }
        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }

        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public decimal LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }
        public int YearInLoanTerm
        {
            get { return yearInLoanTerm; }
            set { yearInLoanTerm = value; }
        }

        public override string ToString ()
        {
            string info = $"\nCustomer name: {CustomerFirstName} {CustomerLastName}" +
                $"\nLoan amount: {LoanAmount}\nYear in Loan term: {YearInLoanTerm}";

            return info;
        }

        //calcualte interest
        public abstract decimal CalculateInterest();
    }


}
