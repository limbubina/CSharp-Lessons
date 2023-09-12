using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Bina_Section10
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Array_Test()
        {
            // 14 position from 0 - 13
            int[] scores = new int[14];

            //put a score in the first position
            scores[0] = 10;

            //store the value of scores[0] to new variable 'score'
            int score = scores[0];

            int numPositions = 10;
            int[] myArray = new int[numPositions];
        }

        [TestMethod]

        public void ForEach_Loop_Test()
        {
            int[] scores = { 10, 20, 4, 5 };

            foreach (int count in scores)
            {
                Console.WriteLine(count);
            }
        }
        // Pass Array
        [TestMethod]

        public void Pass_Array_Method()
        {
            int[] numbers = { 2, 3, 4, 7, 8, 9 };
            int sum = TotalScores(numbers);
        }

        public int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        //Pass Array element

        [TestMethod]

        public void Pass_Array_Element()
        {
            int[] scoreNumbers = { 2, 3, 4, 7, 8, 9, 15 };

            foreach (int number in scoreNumbers)
            {
                Console.WriteLine(CheckScore(number));
            }

            //check single element in array
            CheckScore(scoreNumbers[1]);
        }

        public string CheckScore(int score)
        {
            if (score >= 10)
            {
                return "Pass";
            }

            else
            {
                return "fail";
            }
        }

        [TestMethod]

        public void Array_Class_Methods()
        {
            double[] waterDepth = { 12.4, 5.5, 12.4 };
            Array.Sort(waterDepth);

            foreach (double wVal in waterDepth)
            {
                Console.WriteLine(wVal + "\t");
            }

            Array.Reverse(waterDepth);

            foreach (double wVal in waterDepth)
            {
                Console.WriteLine(wVal + "\t");
            }
        }

        [TestMethod]
        public void Array_Copy_Method()
        {
            double[] array1 = { 1, 2, 3, 4 };
            double[] copiedArray = new double[array1.Length] ;
            Array.Copy(array1, copiedArray, array1.Length);
            
            foreach(double num in copiedArray)
            {
                Console.WriteLine(num);

            }
        }









    }
}
