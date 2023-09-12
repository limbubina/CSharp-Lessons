using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BinaSection9Quiz1
{
    internal class BinaQuiz1
    {
        static void Main(string[] args)
        {

            int[] validRange = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] userInput = new int[5];
            int countValid = 0;
            //int countInvalid = 0;
           
            Console.WriteLine("Please enter your input");

            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = Convert.ToInt32((Console.ReadLine()));
            }
            int totalValid = 0;
            int totalInvalid = 0;
            foreach (int value in userInput)

            {
                //Console.Write(value + " ");              
                if (value > 0 && value < 10)
                {
                    totalValid++;

                    countValid = userInput.Count(c => c == value);
                    Console.WriteLine($"Valid value - {value}\t {countValid} times");
                    
                }
                else
                {
                    totalInvalid++;
                    //countInvalid = userInput.Count(c => c == value);
                    //Console.WriteLine($"Invalid value - {value}\t {countInvalid} times");

                }               
            }
            Console.WriteLine($"Total valid entries = {totalValid}");
            Console.WriteLine($"Total invalid entries = {totalInvalid}");

            //display distinct valid entries and count how many times it occured
            //in tabular form

          // int numberofElement = userInput.Distinct().Count();

            IEnumerable<int> distinctInput = userInput.Distinct();

            var groups = distinctInput.GroupBy(z => z);

            Console.WriteLine($"Distinct Values:\t Count");

            //foreach(int value in distinctInput)
            //{
            //    Console.WriteLine($"{value}\t\t ");
            //}

            foreach(var group in groups)
            {
                Console.WriteLine("{0} \t {1}", group.Key, group.Count());
            }
           // Console.WriteLine($"Total valid distinct values : {numberofElement}");


        }
    }
}

