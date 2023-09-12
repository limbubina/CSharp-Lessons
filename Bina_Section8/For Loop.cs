using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section8
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void Test_For_Loops()
        {

            //for(initliasise; test; update)
            //{} run everytime it is true
            //like while loop 
            
            int inner;

            for (int outer = 0; outer <=2; outer++)
            {
                //int inner;
                for (inner = 10; inner >= 6; inner--)
                {
                    Console.WriteLine($"Outer:{outer}\tInner:{inner}");                                  
                }
                
            }

        }
    }
}
