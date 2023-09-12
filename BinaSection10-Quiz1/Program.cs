using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BinaSection9Quiz1
{
    internal class BinaQuiz1Copy
    {
        static void Main(string[] args)
        {
            var validRangeList = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            //Allowing user to enter into array
            Console.WriteLine("Enter your Input");
            var userArrayList = new ArrayList();

            for (int i = 0; i < 11; i++)
            {
                userArrayList.Add(Console.ReadLine());
            }

            int totalValid = 0;
            int totalInvalid = 0;
            var validInput = new ArrayList();

            // valid and ivnalid values
            foreach (var item in userArrayList)
            {
                //Console.Write(item + " " + "\n");

                if (validRangeList.Contains(item))
                {
                    totalValid++;

                    validInput.Add(item);

                    //Console.WriteLine("{0}       {1}", item, userArrayList.Count);

                }
                else
                {
                    totalInvalid++;
                }

            }
            Console.WriteLine($"Total valid entries = {totalValid}");
            Console.WriteLine($"Total invalid entries = {totalInvalid}");

            //Valid entries
            //Count distinct value and how many times it occured

            //var dictionary = new Dictionary<object, int>();

            Console.WriteLine("Valid entries: ");
            foreach (var value in validInput)
            {
                Console.Write(value + "" + "\n");

               
                //    dictionary[value] = (dictionary.ContainsKey(value) ? dictionary[value] : 0) + 1;              
            }

            for(int i = 0; i < validInput.Count; i++)
            {
                for(int j = i+1; i < validInput.Count; i++)
                {

                }
            }
            //foreach (var pair in dictionary)
            //{
            //    Console.WriteLine(pair.Key + " repeats " + (pair.Value - 1) + " times");
            //}


        }


    }
}


