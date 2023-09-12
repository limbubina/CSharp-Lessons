using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection9
{
    [TestClass]
    public class Test_Tuple
    {
        [TestMethod]
        public void Test_Tuples()
        {
            //create the Tuple
            //Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "Cat", false);

            (int, string, bool) myTuple = (1, "Cat", false);

            //access the Tuple

            if (myTuple.Item1 == 1)
            {
                Console.WriteLine(myTuple.Item1);
            }
            if (myTuple.Item2 == "Cat")
            {
                Console.WriteLine(myTuple.Item2);
            }
            if (myTuple.Item3)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }

        //access te
    }
}
