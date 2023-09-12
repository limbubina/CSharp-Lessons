using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section8
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1;
            while (number < 11)
            {
                //the code that will continue to execute while the statement conditional is true
                Console.WriteLine(number);
                number++; // number++ = number + 1
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;

            Console.WriteLine("Post increment value is: {0}", number++);//number value is 2 after the opertation
            Console.WriteLine("Pre increment value is: {0}", ++number);
            Console.WriteLine("Post decrement value is: {0}", number--);
            Console.WriteLine("Pre decrement value is: {0}", --number);
        }

        //[TestMethod] //cannot test this here as its console program

        //public void Test_Sentinel_controlled_Loop()
        //{
        //    string inValue = "";
        //    while(inValue != "-99")
        //    {
        //        Console.Write("\nEnter value (-99 to exit): ");
        //        inValue = Console.ReadLine();
        //    }
        //    Console.ReadKey();
        //}

        [TestMethod]

        public void Nested_Loops()
        {
            int A = 1;
            int B = 1;
            while(A <= 5)
            {
                Console.WriteLine(A);
                while(B <= A)
                {
                    Console.WriteLine(B);
                    B++;
                }
                A++;
            }

        }
    }
}
