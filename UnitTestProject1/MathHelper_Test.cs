using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaSection9
{
    [TestClass]
    public class MathHelper_Test
    {
        [TestMethod]
        public void TestSquare()
        {
            MathHelper_Test binaTest = new MathHelper_Test();
            int result = binaTest.Square(6);
            Assert.AreEqual(36, result);
        }

        public int Square(int aValue)
        {
            return aValue * aValue;
        }


        [TestMethod]
        public void Test_Static_Square()
        {
            int result = MathHelper.Square(5);
            Assert.AreEqual(25, result);
        }

        // Named parameters
        [TestMethod]
        public void Test_StaticSqaure_Named()
        {
            Assert.AreEqual(36, MathHelper.Square(aValue: 6));
        }

        [TestMethod]
        public void Test_Static_Addnumber()
        {
            int sum1 = MathHelper.AddNumber(5, 6);

            int sum2 = MathHelper.AddNumber(number1: 6, number2: 6);

            int number = 5;
            int sum3 = MathHelper.AddNumber(number, number2: 7);

            int sum4 = MathHelper.AddNumber(number2: 5, number1: 8);
            Console.WriteLine(sum4);

        }

        //Optional Parameters
        [TestMethod]
        public void Test_Optional_Parameters()
        {
            int sumA = MathHelper.OptionalAddNumber(0);

            int sumB = MathHelper.OptionalAddNumber(2);

            int sumC = MathHelper.OptionalAddNumber(); //as both parameters are optional, it will use the values that are entered in the Method
            
            int sumD = MathHelper.OptionalAddNumber(number2:5);//skips the parameter for number1 and assign new value for number 2
            Console.WriteLine(sumD);
        }

        //Out and Ref


        [TestMethod]

        public void Test_Out_Parameter()
        {
            int number1 = 100;// this value is discarded when its passed to the Method
            MathHelper.NumbersOut(out number1);
            Assert.AreEqual(10, number1);
        }
        [TestMethod]

        public void Test_Ref_Parameter()
        {
            int number1 = 10;
            MathHelper.NumbersRef(ref number1);
            Assert.AreEqual(15, number1);
        }
    }
}
