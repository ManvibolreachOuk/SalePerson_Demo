using System;
using System.Collections.Generic;
using System.Text;

namespace SalepersonDemo_Lab8
{
    abstract class Salesperson
    {
        protected string firstName;
        protected string lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        protected Salesperson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
