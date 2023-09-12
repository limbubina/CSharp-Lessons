using System;
using System.Linq.Expressions;

namespace Bina_Section6
{
    internal class Receipt
    {
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal itemUnitPrice;
        private int quantityPurchased;

        //Constructor

        public Receipt(int receiptNumber, string dateOfPurchase, int customerNumber,
                       string customerFirstName, string customerLastName, string customerAddress, string customerPhoneNumber,
                       int itemNumber, string itemDescription, decimal itemUnitPrice, int quantityPurchased)
        {

            ReceiptNumber = receiptNumber;
            DateOfPurchase = dateOfPurchase;
            CustomerNumber = customerNumber;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            CustomerAddress = customerAddress;
            CustomerPhoneNumber = customerPhoneNumber;
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            ItemUnitPrice = itemUnitPrice;
            QuantityPurchased = quantityPurchased;
        }

        //Properties
        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                //if (value <= 0)
                //{
                //    throw new ArgumentException("Receipt number is 0 or less than 0");
                //}
                //receiptNumber = value;

                if (value > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    throw new ArgumentException("Receipt number is 0 or less than 0");
                }
            }
        }
        public string DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Customer number is 0 or less than 0");
                }
                customerNumber = value;
            }
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
        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        public string CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set { customerPhoneNumber = value; }
        }
        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Item number is 0 or lessthan 0");

                }
                else if (value > 9999)
                {
                    throw new ArgumentException("Item number is greater than 9999");

                }
                itemNumber = value;
            }
        }
        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public decimal ItemUnitPrice
        {
            get { return itemUnitPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Unit price is 0 or lessthan 0");

                }
                else if (value > 9999)
                {
                    throw new ArgumentException("Unit price is greater than 9999");

                }
                itemUnitPrice = value;
            }
        }

        public int QuantityPurchased
        {
            get { return quantityPurchased; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantiy purchased is 0 or less");

                }
                quantityPurchased = value;
            }
        }

        //Methods

        public decimal CalculateTotalCost()
        {
           // decimal totalCost = ItemUnitPrice * QuantityPurchased;
            return ItemUnitPrice * QuantityPurchased;
        }

        public override string ToString()
        {
            //string stringPhoneNumber = customerPhoneNumber.ToString("D");
            // string test = string.Format("{0:00}",stringPhoneNumber);
            string totalCost = CalculateTotalCost().ToString("C");
            return $"Customer: {CustomerFirstName} {CustomerLastName}\nPhone: {CustomerPhoneNumber}\nTotal Purchases: {totalCost}";
        }

    }
}
