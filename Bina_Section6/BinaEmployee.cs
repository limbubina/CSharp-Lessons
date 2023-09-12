using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section6
{
    internal class BinaEmployee
    {

        string firstName;
        string lastName;
        //DateTime dateOfHire;
        //string description;
        //double monthlySalary;

        //Constructor      
        public BinaEmployee(string EfirstName, string ElastName)
        {
            FirstName = EfirstName;
            LastName = ElastName;

        }

        //Properties
        public int EmployeeID
        {
            get;
            set;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //method1 - return name with space

        public string FullName()
        {
            // string result = ($"{FirstName} {LastName}");
            //return result;
            return ($"{FirstName} {LastName}");

        }

        //method 2 - return lastname, firstname
        public string SortedName()
        {
            string result = ($"{LastName}, {firstName}");
            return result;
        }     

    }
}
