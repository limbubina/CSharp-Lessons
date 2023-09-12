using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section12
{
    internal class Transaction:ITransaction
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction (string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public override string ToString()
        {
            return String.Format("Transation: {0}\n" +
                "Date: {1}\n" +
                "Amount:{2}", tCode, date, getAmount()) ;
        }
    }
}
