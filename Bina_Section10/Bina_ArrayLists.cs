using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Bina_Section10
{
    [TestClass]
    public class Bina_ArrayLists
    {
        [TestMethod]
        public void Test_Creating_Lists()
        {
            ArrayList myArray = new ArrayList(); //no data is picked or how many positions we want
            myArray.Add("Today");
            myArray.Add(2);
            myArray.Add(3);
            myArray.Add(4);
            myArray.Add(50M);

            Console.WriteLine(myArray.Count);

            myArray.RemoveAt(3);
            Console.WriteLine(myArray.Count);

        }

        [TestMethod]

        public void Testing_ArrayList()
        {
            ArrayList scores = new ArrayList();
            FillList(scores);

            int sum = TotalScore(scores);
            Console.WriteLine(sum);
        }

        //creating array list
        public void  FillList( ArrayList scores)
        {
            for (int i = 1; i <= 20; i++)
            {
                scores.Add(i);
            }
        }

        //adding scores
        public int TotalScore( ArrayList scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
