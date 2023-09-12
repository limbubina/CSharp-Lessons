using Bina_Section12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section12
{
    internal class Student : Person, ITraveller //inheriting from Person class
    {
        private string major;
        private string studentId;

        public Student(string Id, string sFName, string slName, int sAge, string sMajor, string sId)
            : base(Id, sFName, slName, sAge)//sending student information to base class Person constructor
            
        {
            major = sMajor;
            studentId = sId;
        }

        //public void GetDOB()
        //{
        //    //base.dateofBirth;//can access protected member as this is a child class
        //}
       
        public string GetDestination()
        {
        return "Home";
        }

        public string GetStartLocation()
        {
            return "Home";
        }

        public double DetermineMiles()
        {
           return 75.0;
        }

        public override string ToString()
        {
            return base.ToString() + $"Destination : {GetDestination()}" +
                $"\nStart Location : {GetStartLocation()}" +
                $"\nMiles: {DetermineMiles()}";
        }
    }
}
