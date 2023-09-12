using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section6
{
    internal class BinaCar
    {
        //private variables that help us define properties
        //of a car or of the class


        //these variables belong to class 
        string colour;
        int numberofDoors;
        bool isCovertable;

        //Constructor- factory for creating objects of the class
        //is the same name as the class
        public BinaCar(string carColor, int carDoor, bool CarConvertable) //the variables are like private and only accessible to this 
        {
            //set to the property that has access to accessors
            Colour = carColor;
            IsCovertable = CarConvertable;
            NumberofDoors = carDoor;

        }

        //Get and Set Accessors - Properties that define noun-like
        //attributes of the class
        //Properties are put behind Get and set 

        public string Colour//property should be upper case that's why Colour
        {
            get
            {return colour;} //get the value of colour

            set
            { colour = value; }//change the value of the colour//value is the parameter, hiddne behind
            
        }
        public bool IsCovertable
        {
            get; set;//compiler sets it already so you can write like this
           
        }
        public int NumberofDoors
        {
            get { return numberofDoors;}

            set
            {
               if (value <= 4)
                {
                    numberofDoors = value;
                }
                else
                {
                    //give the user some kind of apprpriate error
                }

            }

        }


        //Methods - Verb attributes that tell what a class can do
        //what makes up acar

        public void Accelerate()
        {
            Console.WriteLine("I am accelerating");
        }

        public bool FamilyCar()
        {
            if(NumberofDoors >= 4)
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
