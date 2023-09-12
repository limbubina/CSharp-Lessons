using Bina_Section12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section12
{
    internal class Professor : Person , ITraveller //inheriting from Person class
    {
        private string major;
        private string subject;

        public Professor(string Id, string sFName, string slName, int sAge, string sMajor, string sub)
            : base(Id, sFName, slName, sAge)//sending student information to base class Person constructor
        {
            major = sMajor;
            subject = sub;
        }

        //public void GetDOB()
        //{
        //    //base.dateofBirth;//can access protected member as this is a child class
        //}
        public string GetDestination()
        {
            return "University";
        }

        public string GetStartLocation()
        {
            return "Home";
        }

        public double DetermineMiles()
        {
            return 80.0;
        }
        public override string ToString()
        {
            return base.ToString() + $"Destination : {GetDestination()}" +
                $"\nStart Location : {GetStartLocation()}" +
                $"\nMiles: {DetermineMiles()}";
        }
    }
}
