using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Bina_Section14
{
    [TestClass]
    public class AdvanceTest
    {
        [TestMethod]
        public void ImplicitCasting()
        {
            Mammal mammal = new Cat();//child class 'Cat' mascarading as base/higher class//allows to access properties/mthods of Cat
            Animal animal = new Cat();
        }

        [TestMethod]
        public void ExplicitCasting()
        {
            double dPi = 3.1315926535;
            int iValue = (int)dPi;
            Console.WriteLine(iValue);
        }

        [TestMethod]
        public void BoxingCasting()
        {
            double dPi = 3.1315926535;

            object oPi = (object)dPi;

        }
        [TestMethod]
        public void UnboxingCasting()
        {
            double dPi = 3.1415926535;
            object oPi = (object)dPi;

            dPi = (double)oPi;
            Console.WriteLine(dPi);
        }

        delegate int del(int i);

        [TestMethod]
        public void TestLamba()
        {
            del mydelegate = x => x * x;

            int j = mydelegate(5);
            Assert.AreEqual(j, 25);


            int testdelegate(int y) => y * y;

            //int testdelegate(int y)
            //{
            //    return y * y;
            //}


            del mydelgate3 = (int b) => b + b;
            del delegate4 = b => b * b;

        }

        [TestMethod]

        public void TestListLambda()
        {
            List<int> elements = new List<int>() { 10, 20, 30, 40 };
            int oddIndex = elements.FindIndex (x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]

        public void TestStatementLambda()
        {

            TestDelegate del = n => { string s = n + "World";Console.WriteLine(s); };

            del("Hello");
           
            //lamda statement passes string n
            //gives back string s
        }
}
}
