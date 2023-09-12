using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
    internal class Student : Person  //inheriting from Person class
    {
        private string major;
        private string studentId;

        public Student(string Id, string sFName, string slName, int sAge, string sMajor, string sId, DateTime sDoB)
            : base(Id, sFName, slName, sAge)//sending student information to base class Person constructor
        {
            major = sMajor;
            studentId = sId;
        }

        //you need to add the abstract method from base class
        //use OVerride Keyword to call the Abstract method
        //public override string GetExcerciseHabits()
        //{
        //    return " Zero time to excercise";
        //}

        public void GetDOB()
        {
            //base.dateofBirth;//can access protected member as this is a child class
        }

        public override string HoursOfSleep()
        {
            return "A student gets 6 hours of sleep";
        }
    }
}
