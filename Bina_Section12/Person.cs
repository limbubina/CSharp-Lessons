using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section12
{
    abstract class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person (string id, string lName, string fName, int anAge)
        {
            idNumber = id;
            lastName = lName;
            firstName = fName;
            age = anAge;
        }

        public override string ToString()
        {
            return $"First name : {firstName}" +
                $"\nLast name: {lastName}";
        }
    }
}
