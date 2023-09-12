using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section6
{
    internal class BinaCar2
    {
        //private variable that help us define properties of a car. These variables exists for whole class
        string colour;
        int numberofDoors;
        //bool isCovertible;
        int speed;

        //Constructor
        //factory for creating objects of the class
        //properties is being set to incoming value from constructor

        public BinaCar2(string carColour, int doors, bool convertible)
        {
            Colour = carColour;
            NumberofDoors = doors;
            IsCovertible = convertible;

        }

        //Get and Set accessrros
        //properites that define noun- like attibutes of the class.
        //helps us control access to varaibles in this class
        public string Colour
        {
            get
            { return colour; }
            set
            { colour = value; }

        }
        public bool IsCovertible
        {
            get;
            set;
        }

        public int NumberofDoors
        {
            get { return numberofDoors; }
            set
            {
                if (value <= 4)
                {
                    numberofDoors = value;

                }
                else
                {
                    //
                }
            }
        }

        //Methods
        //verb attributes that tell what a class can do 
        public void Accelerate()
        {
            //int speed = 0; 
            Console.WriteLine("I am accelerating to" + speed + "miles per hour");
        }

        public bool FamilyCar()
        {
            if (NumberofDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
