using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bina_Section10
{
    [TestClass]
    public class BinaSection10_Exam
    {

        [TestMethod]
        //Test adding array 
        public void Create_ArrayList()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            Console.WriteLine("Original ArrayList \n");
            PrintArrayList(dataList);//printing orginal arraylist

            //Remove strings from arraylist          
            ArrayList numberArrayList = NumbersOnly(dataList);

            //Print number only list
            Console.WriteLine("\nNumbers only Array\n");
            PrintArrayList(numberArrayList);

            //Print total sum        
            double totalsum = Add_Valid_Numbers(numberArrayList);
            Console.WriteLine($"\nTotal sum : {totalsum}\n");

            Assert.AreEqual(160.5, totalsum);
        }

        //Method to check for numbers only
        public ArrayList NumbersOnly(ArrayList list)
        {
            //Remove string from arraylist
            //Add numbers as List

            ArrayList numberArrayList = new ArrayList();
            double result;
            foreach (var x in list)
            {
                // bool parseSuccessful;
                if (Double.TryParse(Convert.ToString(x), out result) == true)
                {
                    numberArrayList.Add(result);
                }
            }
            return numberArrayList;
        }

        // Method to add valid numbers only
        public double Add_Valid_Numbers(ArrayList numberArrayList)
        {
            double sum = 0;
            foreach (double number in numberArrayList)
            {
                sum += number;
            }
            return sum;
        }

        //MEthod to print elements in array
        public void PrintArrayList(ArrayList myArrayList)
        {
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
