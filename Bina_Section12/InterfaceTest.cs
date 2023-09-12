using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bina_Section12
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void Test_Traveller()
        {
            Professor prof1 = new Professor("1111", "Bob", "Baker", 26, "Computer Science", "9999");
            Professor prof2 = new Professor("0987", "Millie", "Chi", 78, "Physics", "9823");
            Student stu1 = new Student("1234", "John", "Hi", 15, "Chemistry", "84673");
            Student stu2 = new Student("2341", "Ola", "Hello", 45, "Drama", "29912");

            Person[] listofPeople = new Person[4];

            listofPeople[0] = prof1;
            listofPeople[1] = prof2;
            listofPeople[2] = stu1;
            listofPeople[3] = stu2;

            foreach(Person someone in listofPeople)
            {
                Console.WriteLine(someone);
            }


        }
    }
}
