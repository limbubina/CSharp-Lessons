using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Bina_Section11
{
    [TestClass]
    public class TicketTest
    {
        [TestMethod]
        public void Test_Muscial()
        {
            DateTime muscialDate = new DateTime(2023, 10, 15);
            Musical myMusical = new Musical("Musical", 10, "1A", muscialDate, "London", "The Lion King", "Musical Actor");
            Console.WriteLine(myMusical);
        }

        [TestMethod]
        public void Test_Lecture()
        {
            DateTime lectureDate = new DateTime(2023, 11, 17);
            Lecture myLecture = new Lecture("Lecture", 20, "23A", lectureDate, "Nottingham", "Mr. Johnson", "Stars & Moon");
            Console.WriteLine(myLecture);
        }
        [TestMethod]
        public void Test_Play()
        {
            DateTime playDate = new DateTime(2023, 10, 15);
            Play myPlay = new Play("Play", 39, "76B", playDate, "Birmingham", "ComedyPlay", "Gabriel");
            Console.WriteLine(myPlay);
        }
    }
}
