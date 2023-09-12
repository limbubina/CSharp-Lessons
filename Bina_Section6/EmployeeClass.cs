using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section6
{
    internal class EmployeeClass
    {
        int employeeId;
        string firstName;
        string lastName;
        string title;

        //Constructors
        public EmployeeClass(string CfirstName, string CfastName)
        {
            FirstName = CfirstName;
            LastName = CfastName;
        }

        public EmployeeClass(string firstName, string lastName, int employeeId, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Title = title;
        }


        //get set
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName { get; set; }

        public int EmployeeId
        {
            get;
            set;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value == "Manager")
                {
                    title = value;
                }
                else
                {
                    title = "Staff"; //if it's not manager it will set the value to 'Staff'
                }
            }
        }

        //METHODS

        public string Sort1()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        public string Sort2()
        {
            string fulNameSorted = $"{LastName}, {FirstName}";
            return fulNameSorted;
        }

        public string JobLocation()
        {
            if (Title == "Manager")
            {
                return "Boston";
            }
            else if (Title == "Staff")
            {
                return "Chicago";
            }
            else if (Title == "HR")
            {
                return "London";
            }
            return "New York";
        }

        public override string ToString()
        {
            //return base.ToString();//by default it returns class name

             return EmployeeId + " " + FirstName + LastName + " Job Title: " + Title; // print this instead of the default class name
        }
        
    }




}

