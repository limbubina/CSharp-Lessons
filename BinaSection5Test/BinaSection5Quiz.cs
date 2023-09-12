using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection5Test
{
    [TestClass]
    [TestCategory ("Section5TEST")]
    public class BinaSection5Quiz
    {
        // variable to hold fahrenheit and celsius

        double celcius = 30.0;
        double fahrenheit = 86.0;

        [TestMethod]
        public void Convert_F_TO_C()
        {      
            double FtoC = ((fahrenheit - 32.0) * 5.0 / 9.0);
            Console.WriteLine("The temp in F {0} is {1} in C",fahrenheit,FtoC);
            Assert.AreEqual(30.0,FtoC,0.001);

        }

        [TestMethod]
        public void Convert_C_TO_F()
        {
            double CtoF = ((celcius * (9.0 / 5.0)) + 32.0);
            Console.WriteLine($"The temp in C, {celcius} is {CtoF} in F");
            Assert.AreEqual(86.0, CtoF,0.001);

        }


    }
}
