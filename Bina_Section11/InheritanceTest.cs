using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Bina_Section11
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            //Person myPerson = new Person("1234", "Baker", "Sarah", 24);

            //Student myStudent = new Student("1111", "Bob", "Baker", 26, "Computer Science", "9999");

            //string response = myStudent.GetExcerciseHabits();
        }
        [TestMethod]

        public void Composition_Test()
        {
            DateTime dob = new DateTime(1980, 5, 20);//need to setup an instance of this object calling a constructor
            Student myStudent = new Student("1111", "Bob", "Baker", 26, "Computer Science", "9999",
                dob);

        }

        [TestMethod]
        public void Test_Protected()
        {
            DateTime dob = new DateTime(1980, 5, 20);//need to setup an instance of this object calling a constructor
            Student myStudent = new Student("1111", "Bob", "Baker", 26, "Computer Science", "9999",
                dob);
            //cannot access protected member in parent class
        }

        [TestMethod]
        public void Test_Student_As_PErson()
        {
            ArrayList PersonList = new ArrayList();

            Person myPerson = new Person ("1234", "Baker", "Sarah", 24);

            DateTime dob = new DateTime(1980, 5, 20);

            Student myStudent = new Student("1111", "Bob", "Baker", 26, "Computer Science", "9999",
                dob);

            PersonList.Add(myPerson);
            PersonList.Add(myStudent);

            foreach(Person item in PersonList)
            {
                
                Console.WriteLine(item.HoursOfSleep());
            }

        }

        [TestMethod]
        public void Test_Sealed()
        {
            Pen myPen = new Pen("ball point"); //allows to access classses 
        }

      
    }
}
