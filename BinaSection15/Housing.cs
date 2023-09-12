using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection15
{
    internal class Housing
    {
        private string address;
        private string typeOfConstruction;
        private int yearBuilt;

        //constructor

        public Housing(string address, string typeOfConstruction, int yearBuilt)
        {
            Address = address;
            TypeOfConstruction = typeOfConstruction;
            Yearbuilt = yearBuilt;
        }

        //Properties
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string TypeOfConstruction
        {
            get { return typeOfConstruction; }
            set { typeOfConstruction = value; }
        }
        public int Yearbuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }

        }

        //virtual method for projected rental amount
        public virtual decimal ProjectRentalAmt()
        {
            return 0M;
        }

        //override string
        public override string ToString()
        {
            string baseClassInfo = 
                $"\n Address: {Address}" +
                $"\n Type of Constructon: {TypeOfConstruction}" +
                $"\n Year built: {Yearbuilt}";
            return baseClassInfo;
        }

    }


}
