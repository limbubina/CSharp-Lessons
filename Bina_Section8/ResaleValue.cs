using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section8
{
    internal class ResaleValue
    {
        private decimal itemPrice;


        //constructor
        public ResaleValue(decimal itemPrice)
        {
            ItemPrice = itemPrice;
        }

        // Properties

        public decimal ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

    }
}
