using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
      class Person
    {
        //private access modifiers are restricted ot only memebers of current class 
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;
        protected DateTime dateofBirth;

        //other classes inside same namespace can be able to access it
        public Person()
        {

        }

        public Person(string id, string lName, string fName, int anAge)
        {
            //setting to private variable
            idNumber = id;
            lastName = lName;
            firstName = fName;
            age = anAge;
            //dateofBirth = dob;
        }

        //Abstract method - //no body can be added here
        //you need to add this abstract method from base class in Derived class
        //public abstract string GetExcerciseHabits(); 

        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of sleep";
        }
       
    }
}
