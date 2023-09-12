using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection9
{
    internal class MathHelper
    {
        public static int Square (int aValue)
        {
            return aValue * aValue;
        }

        public static int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        //Optional Parameter
        //number 1 & 2 is Optional
        // = makes it optional
        
        public static int OptionalAddNumber(int number1 = 5, int number2 = 10)
        {
            return number1 + number2;
        }

        public static void NumbersOut (out int value)
        {
            value = 0;//mandatory to instilaise a variable
            value = value + 10 ;
            
        }

        public static void NumbersRef ( ref int value)
        {
            //value = 20; not mandaotry to instilaise a variable
            value = value + 5;
        }
        
    }
}
