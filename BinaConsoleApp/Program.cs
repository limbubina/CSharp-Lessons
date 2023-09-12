using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int number1;
            //number1 = Convert.ToInt32(Console.ReadLine());

            //variables

            //string firstName;
            //string age;

            ////ask user their name
            //Console.WriteLine("Your First Name?");
            //firstName = Console.ReadLine();

            //Console.WriteLine("Your age");
            //age = Console.ReadLine();

            /*..............Concatenation.....................*/
            ////Concatenation
            ////string response = "Your name is " + firstName + " and your age is " + age + " years old";

            ////interpolation
            //string response = $"Your name is {firstName} and you are {age} yours old";
            //Console.WriteLine(response);
        
            /* .......................Interpolation.................................*/

            /* Format output */
            string itemName = "Widget";

            double pricePerKg = 15.43;
            string outputString;

            outputString = String.Format("{0,10} {1,10}", itemName, pricePerKg); //second number is alignment number

            //output table with column header
            Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price")); //header for the column above
            Console.WriteLine(outputString);


            //String.format(string, object[])
            //DateTime date1 = new DateTime(2022, 01, 02);
            //decimal temp = 24m;
            //string result2 = string.Format("Temperature on {0:1");

            //literal string
            string testLiteral = @"C:\file\test";
            Console.WriteLine(testLiteral);
        }
    }
}
